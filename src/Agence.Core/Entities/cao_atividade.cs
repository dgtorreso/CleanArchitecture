namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_atividade")]
    public partial class cao_atividade : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_atividade { get; set; }

        [Required]
        [StringLength(30)]
        public string ds_atividade { get; set; }

        public long co_tipo_usuario { get; set; }
    }
}
