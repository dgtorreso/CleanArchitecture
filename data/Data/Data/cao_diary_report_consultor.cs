namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_diary_report_consultor")]
    public partial class cao_diary_report_consultor
    {
        [Key]
        public int co_diary_report_consultor { get; set; }

        public int co_movimento { get; set; }

        public int co_atividade { get; set; }

        [Required]
        public string ds_empresa { get; set; }

        [Required]
        public string ds_assunto { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dt_agendamento { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dt_agendamento_fim { get; set; }

        public float vl_fechamento { get; set; }

        public long? co_cliente { get; set; }
    }
}
