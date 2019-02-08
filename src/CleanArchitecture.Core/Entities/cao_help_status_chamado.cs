namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_help_status_chamado")]
    public partial class cao_help_status_chamado : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_status { get; set; }

        [Required]
        [StringLength(50)]
        public string ds_status { get; set; }
    }
}
