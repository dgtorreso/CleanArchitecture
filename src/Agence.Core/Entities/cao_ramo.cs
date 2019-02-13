namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_ramo")]
    public partial class cao_ramo : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_ramo { get; set; }

        [Required]
        [StringLength(60)]
        public string ds_ramo { get; set; }
    }
}
