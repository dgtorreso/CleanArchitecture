namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_obs_cliente")]
    public partial class cao_obs_cliente
    {
        [Key]
        public long co_obs { get; set; }

        [Required]
        [StringLength(250)]
        public string descricao { get; set; }

        public long co_cliente { get; set; }

        [StringLength(30)]
        public string co_usuario { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dt_obs { get; set; }
    }
}
