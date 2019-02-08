namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_uf")]
    public partial class cao_uf : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_uf { get; set; }

        [Required]
        [StringLength(5)]
        public string ds_uf { get; set; }
    }
}
