namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_movimento_os")]
    public partial class cao_movimento_os
    {
        [Key]
        public int co_movimento_os { get; set; }

        public int nu_os { get; set; }

        public long co_sistema { get; set; }

        public long? co_tipo_movimento { get; set; }

        public long? nu_valor { get; set; }

        public string ds_valor { get; set; }

        [StringLength(30)]
        public string usuario_obs { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dt_ini { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dt_fim { get; set; }
    }
}
