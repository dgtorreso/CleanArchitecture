namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_tipo_conhecimento_usuario")]
    public partial class cao_tipo_conhecimento_usuario : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_conhecimento { get; set; }

        [StringLength(20)]
        public string ds_conhecimento { get; set; }

        public long co_sistema { get; set; }
    }
}
