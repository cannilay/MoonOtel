namespace MoonOtel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Servis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servis()
        {
            MusteriHesap = new HashSet<MusteriHesap>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int servisID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        public int? ucret { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusteriHesap> MusteriHesap { get; set; }
    }
}
