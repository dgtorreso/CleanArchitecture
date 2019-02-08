namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("permissao_sistema")]
    public partial class permissao_sistema
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_usuario { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal co_tipo_usuario { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal co_sistema { get; set; }

        [Required]
        [StringLength(1)]
        public string in_ativo { get; set; }

        [StringLength(20)]
        public string co_usuario_atualizacao { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dt_atualizacao { get; set; }
    }
}
