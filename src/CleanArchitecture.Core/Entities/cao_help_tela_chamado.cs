namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_help_tela_chamado")]
    public partial class cao_help_tela_chamado : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_tela { get; set; }

        public int co_cliente { get; set; }

        public int co_sistema { get; set; }

        [Required]
        [StringLength(200)]
        public string ds_tela { get; set; }
    }
}
