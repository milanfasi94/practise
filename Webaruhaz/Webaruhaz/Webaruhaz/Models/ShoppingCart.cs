namespace Webaruhaz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShoppingCart")]
    public partial class ShoppingCart
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Created { get; set; }

        public string Name { get; set; }
        public double osszeg { get; set; }
        public int itemID{ get; set; }
        [StringLength(36)]
        public string instanceID { get; set; }
    }
}
