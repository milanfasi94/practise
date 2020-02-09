namespace Webaruhaz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Parfum")]
    public partial class Parfum
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public double Price { get; set; }

        public bool Men { get; set; }

        public bool Akcios { get; set; }

        public int Akcioszazalek { get; set; }

        
    }

}
