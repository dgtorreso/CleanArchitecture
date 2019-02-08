namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_aviso")]
    public partial class cao_aviso : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_aviso { get; set; }

        [Required]
        public string ds_aviso { get; set; }
    }
}
