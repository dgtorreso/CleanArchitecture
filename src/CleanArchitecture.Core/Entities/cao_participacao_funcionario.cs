namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_participacao_funcionario")]
    public partial class cao_participacao_funcionario : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_part_funcionario { get; set; }

        public float pc_participacao { get; set; }

        [Required]
        [StringLength(20)]
        public string co_usuario { get; set; }

        public byte co_escritorio { get; set; }

        [Column(TypeName = "date")]
        public DateTime dt_referencia { get; set; }
    }
}
