namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_tipo_sistema_usuario")]
    public partial class cao_tipo_sistema_usuario : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_sistema { get; set; }

        [StringLength(40)]
        public string ds_sistema { get; set; }
    }
}
