namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_bonus_status")]
    public partial class cao_bonus_status
    {
        public int id { get; set; }

        [Required]
        [StringLength(128)]
        public string co_usuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_solic { get; set; }

        [Required]
        [StringLength(128)]
        public string mes { get; set; }

        [Required]
        [StringLength(128)]
        public string valor { get; set; }

        [StringLength(10)]
        public string is_solic { get; set; }

        [StringLength(10)]
        public string is_pg { get; set; }

        [StringLength(10)]
        public string is_horas { get; set; }
    }
}
