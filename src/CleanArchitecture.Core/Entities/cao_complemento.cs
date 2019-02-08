namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_complemento")]
    public partial class cao_complemento : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_complemento { get; set; }

        public string ds_complemento { get; set; }
    }
}
