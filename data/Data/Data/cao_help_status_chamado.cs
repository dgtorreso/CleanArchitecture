namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_help_status_chamado")]
    public partial class cao_help_status_chamado
    {
        [Key]
        public int co_status { get; set; }

        [Required]
        [StringLength(50)]
        public string ds_status { get; set; }
    }
}
