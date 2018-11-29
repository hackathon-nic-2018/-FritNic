namespace FritNic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetalleValoracion")]
    public partial class DetalleValoracion
    {
        [Key]
        public int iddetallevarloracion { get; set; }

        public int idnegocio { get; set; }

        public int idvaloracion { get; set; }

        public virtual Fritanga Fritanga { get; set; }

        public virtual Valoracion Valoracion { get; set; }
    }
}
