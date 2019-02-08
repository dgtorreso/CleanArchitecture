namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_status_os")]
    public partial class cao_status_os : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_status_atual { get; set; }

        [Required]
        [StringLength(50)]
        public string ds_status { get; set; }
    }
}
