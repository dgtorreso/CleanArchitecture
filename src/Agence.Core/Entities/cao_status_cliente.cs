namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_status_cliente")]
    public partial class cao_status_cliente : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_status { get; set; }

        [Required]
        [StringLength(100)]
        public string ds_status { get; set; }
    }
}
