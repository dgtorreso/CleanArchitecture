namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_permissao")]
    public partial class cao_permissao : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_usuario { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string permissao_intervalo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string permissao_hora_extra { get; set; }

        public virtual cao_usuario cao_usuario { get; set; }
    }
}
