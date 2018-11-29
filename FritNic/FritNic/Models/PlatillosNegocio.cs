namespace FritNic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlatillosNegocio")]
    public partial class PlatillosNegocio
    {
        [Key]
        public int idplatillonegocio { get; set; }

        public int idnegocio { get; set; }

        public int idplatillo { get; set; }

        public virtual Fritanga Fritanga { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
