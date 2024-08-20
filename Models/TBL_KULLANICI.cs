namespace YonetimPanel48.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_KULLANICI
    {
        [Key]
        public int K_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string K_ADI { get; set; }

        [Required]
        [StringLength(100)]
        public string K_PAROLA { get; set; }
    }
}
