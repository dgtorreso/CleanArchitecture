namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_tipo_idioma_usuario")]
    public partial class cao_tipo_idioma_usuario : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_idioma { get; set; }

        [StringLength(13)]
        public string ds_idioma { get; set; }
    }
}
