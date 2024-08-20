namespace YonetimPanel48.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_HABER
    {
        [Key]
        public int H_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string P_BASLIK { get; set; }

        [Required]
        [StringLength(1000)]
        public string P_ICERIK { get; set; }
    }
}
