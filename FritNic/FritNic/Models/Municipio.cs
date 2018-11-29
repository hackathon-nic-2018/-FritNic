namespace FritNic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Municipio")]
    public partial class Municipio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Municipio()
        {
            Fritanga = new HashSet<Fritanga>();
        }

        [Key]
        public int idmunicipio { get; set; }

        public int iddepartamento { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        public int idpropietario { get; set; }

        public virtual Departamento Departamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fritanga> Fritanga { get; set; }

        public virtual Propietario Propietario { get; set; }
    }
}
