namespace FritNic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Propietario")]
    public partial class Propietario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Propietario()
        {
            Fritanga = new HashSet<Fritanga>();
            Municipio = new HashSet<Municipio>();
        }

        [Key]
        public int idpropietario { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Column("P.Apellido")]
        [Required]
        [StringLength(50)]
        public string P_Apellido { get; set; }

        [Column("S.Apellido")]
        [Required]
        [StringLength(50)]
        public string S_Apellido { get; set; }

        [Required]
        [StringLength(20)]
        public string Cedula { get; set; }

        public int idmunicipio { get; set; }

        [Required]
        [StringLength(15)]
        public string Telefono { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(30)]
        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fritanga> Fritanga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Municipio> Municipio { get; set; }
    }
}
