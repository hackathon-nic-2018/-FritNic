namespace FritNic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fritanga")]
    public partial class Fritanga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fritanga()
        {
            DetalleValoracion = new HashSet<DetalleValoracion>();
            PlatillosNegocio = new HashSet<PlatillosNegocio>();
        }

        [Key]
        public int idnegocio { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }

        [Column(TypeName = "date")]
        public DateTime Horaapertura { get; set; }

        [Column(TypeName = "date")]
        public DateTime HoraCierre { get; set; }

        [Required]
        [StringLength(20)]
        public string PermisoNegocio { get; set; }

        [Required]
        [StringLength(30)]
        public string Direccion { get; set; }

        public int idmunicipio { get; set; }

        public int idpropietario { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleValoracion> DetalleValoracion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlatillosNegocio> PlatillosNegocio { get; set; }

        public virtual Municipio Municipio { get; set; }

        public virtual Propietario Propietario { get; set; }
    }
}
