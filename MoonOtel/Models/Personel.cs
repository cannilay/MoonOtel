namespace MoonOtel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personel")]
    public partial class Personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personel()
        {
            Oda = new HashSet<Oda>();
        }

        [Key]
        public int personelD { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string soyad { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dogumTarihi { get; set; }

        [StringLength(50)]
        public string cinsiyet { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? iseBaslamaTarihi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? istenCikisTarihi { get; set; }

        [StringLength(50)]
        public string telefon { get; set; }

        [StringLength(50)]
        public string eposta { get; set; }

        public int? maas { get; set; }

        [StringLength(50)]
        public string sifre { get; set; }

        [StringLength(50)]
        public string unvan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oda> Oda { get; set; }
    }
}
