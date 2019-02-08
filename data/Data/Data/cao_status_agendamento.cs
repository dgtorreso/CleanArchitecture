namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_status_agendamento")]
    public partial class cao_status_agendamento
    {
        [Key]
        public long co_status_agendamento { get; set; }

        [Required]
        [StringLength(20)]
        public string ds_status_agendamento { get; set; }
    }
}
