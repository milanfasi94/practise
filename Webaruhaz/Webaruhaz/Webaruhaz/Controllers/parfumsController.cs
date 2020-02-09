using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Webaruhaz.Models;

namespace Webaruhaz.Controllers
{
    public class parfumsController : Controller
    {
        private Model1 db = new Model1();
       
        // GET: parfums
        public ActionResult Index()
        {


            return View(db.Parfum.ToList());


        }
        string shopid = "";
       
       
        public ActionResult kosarba(int id) {

            //Parfum parfum=db.Parfum.Find(id);
            //var parfum = lista.Find(x => x.Id == id);
            List<Parfum>parfumlista = (from x in db.Parfum.ToList()
                             where x.Id == id
                             select x).ToList();
            Parfum parfum = parfumlista.ToArray()[0];
            if (ModelState.IsValid)
            {
                if (shopid == "") {
                    shopid = new Guid().ToString();
                    
                }
               
                ShoppingCart kosarcucc = new ShoppingCart();
                kosarcucc.itemID = parfum.Id;
               
                kosarcucc.instanceID = shopid;
                kosarcucc.Created = DateTime.Now;
                kosarcucc.Name = parfum.Name;
                if (parfum.Akcios)
                {
                    double szam = parfum.Price;
                    double akciosar = Math.Floor((100 - parfum.Akcioszazalek) * szam / 100);
                    kosarcucc.osszeg = Math.Floor(akciosar);
                }
                else {
                    kosarcucc.osszeg = parfum.Price;
                }
                db.ChangeTracker.HasChanges();
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }

            return RedirectToAction("index");
        }

    }
  
    
    }
