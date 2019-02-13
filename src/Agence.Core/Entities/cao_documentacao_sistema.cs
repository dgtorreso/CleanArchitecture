namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_documentacao_sistema")]
    public partial class cao_documentacao_sistema : Agence.Core.SharedKernel.BaseEntity
    {
        public int id { get; set; }

        public int co_sistema { get; set; }

        public string descricao { get; set; }

        [Required]
        [StringLength(30)]
        public string pasta { get; set; }

        public int? sub_grupo { get; set; }

        [Required]
        [StringLength(60)]
        public string co_usuario { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dt_doc { get; set; }

        [Required]
        [StringLength(100)]
        public string arquivo { get; set; }
    }
}
