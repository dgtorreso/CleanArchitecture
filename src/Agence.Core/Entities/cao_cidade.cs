namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_cidade")]
    public partial class cao_cidade : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_cidade { get; set; }

        [Required]
        [StringLength(30)]
        public string no_cidade { get; set; }

        public long co_uf { get; set; }
    }
}
