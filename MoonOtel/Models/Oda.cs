namespace MoonOtel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Oda")]
    public partial class Oda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oda()
        {
            MusteriKayit = new HashSet<MusteriKayit>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int odaID { get; set; }

        public int? fiyat { get; set; }

        [StringLength(50)]
        public string yatakSayisi { get; set; }

        [StringLength(50)]
        public string odaTur { get; set; }

        public int? personelID { get; set; }

        public int? rezerveID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusteriKayit> MusteriKayit { get; set; }

        public virtual MusteriKayit MusteriKayit1 { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
