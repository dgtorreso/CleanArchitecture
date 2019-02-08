namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_log_chamado")]
    public partial class cao_log_chamado
    {
        public int id { get; set; }

        public int co_chamado { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dt_chamado { get; set; }

        [Required]
        [StringLength(128)]
        public string co_usuario { get; set; }

        public int co_daily { get; set; }
    }
}
