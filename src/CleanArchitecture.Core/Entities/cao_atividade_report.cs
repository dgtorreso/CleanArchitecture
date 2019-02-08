namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_atividade_report")]
    public partial class cao_atividade_report : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        public int id { get; set; }

        public int co_cliente { get; set; }

        [StringLength(30)]
        public string inicio { get; set; }

        [StringLength(30)]
        public string fim { get; set; }

        [StringLength(50)]
        public string lembrete { get; set; }

        public int co_atividade { get; set; }

        public int co_os { get; set; }

        [StringLength(60)]
        public string assunto { get; set; }

        public string conteudo { get; set; }

        [Required]
        [StringLength(20)]
        public string status { get; set; }

        [StringLength(30)]
        public string tempo { get; set; }

        [Required]
        [StringLength(50)]
        public string co_usuario { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime data_ativ { get; set; }

        [Required]
        public string retorno { get; set; }

        public int? co_fase { get; set; }
    }
}
