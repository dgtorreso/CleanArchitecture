namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_atividade_consultor")]
    public partial class cao_atividade_consultor : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_atividade { get; set; }

        [Required]
        [StringLength(50)]
        public string ds_atividade { get; set; }

        [StringLength(1)]
        public string ativo { get; set; }
    }
}
