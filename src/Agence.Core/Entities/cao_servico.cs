namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_servico")]
    public partial class cao_servico : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_servico { get; set; }

        [Required]
        [StringLength(50)]
        public string ds_servico { get; set; }
    }
}
