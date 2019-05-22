namespace otomativ_tamirhane.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class arac_ID
    {
        [Key]
        public int AracID { get; set; }

        [StringLength(50)]
        public string Plaka { get; set; }

        [StringLength(50)]
        public string Marka { get; set; }

        public int? Model { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ModelYili { get; set; }

        public virtual yeni_kayit yeni_kayit { get; set; }
    }
}
