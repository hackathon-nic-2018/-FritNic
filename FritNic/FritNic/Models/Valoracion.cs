namespace FritNic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Valoracion")]
    public partial class Valoracion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Valoracion()
        {
            DetalleValoracion = new HashSet<DetalleValoracion>();
        }

        [Key]
        public int idvaloracion { get; set; }

        [Column("valoracion")]
        [Required]
        [StringLength(20)]
        public string valoracion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleValoracion> DetalleValoracion { get; set; }
    }
}
