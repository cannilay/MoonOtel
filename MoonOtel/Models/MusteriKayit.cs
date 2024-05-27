namespace MoonOtel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MusteriKayit")]
    public partial class MusteriKayit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MusteriKayit()
        {
            MusteriHesap = new HashSet<MusteriHesap>();
            Oda1 = new HashSet<Oda>();
        }

        [Key]
        public int musteriID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string soyad { get; set; }

        [StringLength(50)]
        public string cinsiyet { get; set; }

        public string adres { get; set; }

        [StringLength(50)]
        public string telefon { get; set; }

        [StringLength(50)]
        public string eposta { get; set; }

        public int? odaID { get; set; }

        [StringLength(50)]
        public string kisiSayisi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? girisTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? cikisTarihi { get; set; }

        [StringLength(50)]
        public string durum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusteriHesap> MusteriHesap { get; set; }

        public virtual Oda Oda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oda> Oda1 { get; set; }
    }
}
