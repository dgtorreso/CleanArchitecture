namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_movimento_justificativa")]
    public partial class cao_movimento_justificativa : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal co_movimento_justificativa { get; set; }

        [Column(TypeName = "numeric")]
        public decimal co_movimento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal nu_os { get; set; }

        [Required]
        public string ds_justificativa { get; set; }
    }
}
