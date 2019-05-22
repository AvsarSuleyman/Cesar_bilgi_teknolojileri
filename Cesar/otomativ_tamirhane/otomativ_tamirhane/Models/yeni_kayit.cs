namespace otomativ_tamirhane.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class yeni_kayit
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        [StringLength(11)]
        public string Telefon { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public virtual arac_ID arac_ID { get; set; }
    }
}
