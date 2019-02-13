namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_help_motivo_chamado")]
    public partial class cao_help_motivo_chamado : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_motivo { get; set; }

        [Required]
        [StringLength(70)]
        public string ds_motivo { get; set; }
    }
}
