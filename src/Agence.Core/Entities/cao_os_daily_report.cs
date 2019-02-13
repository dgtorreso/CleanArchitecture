namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_os_daily_report")]
    public partial class cao_os_daily_report : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_daily { get; set; }

        public int? co_os { get; set; }

        public int? co_fase { get; set; }

        [StringLength(50)]
        public string co_usuario { get; set; }

        public string ds_assunto { get; set; }

        public TimeSpan? tempo_gasto { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? data { get; set; }

        public int? co_status_atual { get; set; }

        public int? co_chamado { get; set; }

        public int? co_atividade { get; set; }
    }
}
