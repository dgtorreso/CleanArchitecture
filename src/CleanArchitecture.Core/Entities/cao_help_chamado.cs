namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_help_chamado")]
    public partial class cao_help_chamado : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_chamado { get; set; }

        [Required]
        public string ds_chamado { get; set; }

        public string ds_solucao { get; set; }

        public short co_status { get; set; }

        public int co_motivo { get; set; }

        public int co_tela { get; set; }

        public int co_autor { get; set; }

        public int co_filial { get; set; }

        public long co_sistema { get; set; }

        [Column(TypeName = "date")]
        public DateTime dt_chamado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dt_solucao { get; set; }
    }
}
