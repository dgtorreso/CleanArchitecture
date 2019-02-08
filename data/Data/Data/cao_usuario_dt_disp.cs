namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_usuario_dt_disp")]
    public partial class cao_usuario_dt_disp
    {
        [Key]
        public long co_dt_disp { get; set; }

        [StringLength(20)]
        public string co_usuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime dt_disp { get; set; }

        [Column(TypeName = "date")]
        public DateTime dt_alt { get; set; }
    }
}
