namespace MoonOtel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MusteriHesap")]
    public partial class MusteriHesap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int islemID { get; set; }

        public int? musteriID { get; set; }

        public int? hizmetID { get; set; }

        public int? servisID { get; set; }

        public int? tuketilenID { get; set; }

        public virtual Hizmet Hizmet { get; set; }

        public virtual Lokanta Lokanta { get; set; }

        public virtual MusteriKayit MusteriKayit { get; set; }

        public virtual Servis Servis { get; set; }
    }
}
