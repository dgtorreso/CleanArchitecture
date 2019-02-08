namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_agendamento")]
    public partial class cao_agendamento : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_agendamento { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dt_hr_inicio { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dt_hr_fim { get; set; }

        public long co_status_agendamento { get; set; }

        public long co_diary_report_consultor { get; set; }

        public long co_complemento { get; set; }
    }
}
