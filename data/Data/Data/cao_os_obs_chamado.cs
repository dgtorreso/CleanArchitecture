namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_os_obs_chamado")]
    public partial class cao_os_obs_chamado
    {
        [Key]
        public int co_obs { get; set; }

        public int? co_chamado { get; set; }

        [StringLength(80)]
        public string co_usuario { get; set; }

        public string descricao { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dt_obs { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string arquivo_obs { get; set; }
    }
}
