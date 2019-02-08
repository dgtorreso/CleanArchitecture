namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_help_filial")]
    public partial class cao_help_filial : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_filial { get; set; }

        [Required]
        [StringLength(70)]
        public string no_filial { get; set; }

        public int co_cliente { get; set; }

        [Required]
        [StringLength(2)]
        public string estado { get; set; }
    }
}
