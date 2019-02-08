namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_acompanhamento_sistema")]
    public partial class cao_acompanhamento_sistema : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_acompanhamento { get; set; }

        [StringLength(40)]
        public string email { get; set; }

        [StringLength(20)]
        public string senha { get; set; }

        public long? co_sistema { get; set; }

        [StringLength(2)]
        public string status { get; set; }
    }
}
