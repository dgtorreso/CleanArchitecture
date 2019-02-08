namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_help_motivo_chamado")]
    public partial class cao_help_motivo_chamado
    {
        [Key]
        public int co_motivo { get; set; }

        [Required]
        [StringLength(70)]
        public string ds_motivo { get; set; }
    }
}
