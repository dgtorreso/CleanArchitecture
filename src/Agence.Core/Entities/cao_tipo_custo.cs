namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_tipo_custo")]
    public partial class cao_tipo_custo : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte co_tipo_custo { get; set; }

        [Required]
        [StringLength(30)]
        public string descricao { get; set; }
    }
}
