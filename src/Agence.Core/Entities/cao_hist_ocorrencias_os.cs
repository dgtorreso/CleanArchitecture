namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_hist_ocorrencias_os")]
    public partial class cao_hist_ocorrencias_os : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int idocorrencia { get; set; }

        public int? co_os { get; set; }

        [StringLength(20)]
        public string co_usuario { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? data { get; set; }

        [Required]
        [StringLength(7)]
        public string tipo { get; set; }

        [Required]
        public string descricao { get; set; }

        [Required]
        [StringLength(50)]
        public string responsavel { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? data_fechamento { get; set; }

        public virtual cao_usuario cao_usuario { get; set; }

        public virtual cao_os cao_os { get; set; }
    }
}
