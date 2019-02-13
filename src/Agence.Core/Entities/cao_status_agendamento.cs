namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_status_agendamento")]
    public partial class cao_status_agendamento : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_status_agendamento { get; set; }

        [Required]
        [StringLength(20)]
        public string ds_status_agendamento { get; set; }
    }
}
