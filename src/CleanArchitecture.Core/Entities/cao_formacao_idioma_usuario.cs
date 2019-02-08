namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_formacao_idioma_usuario")]
    public partial class cao_formacao_idioma_usuario : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_usuario { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int co_idioma { get; set; }

        public int? nv_leitura { get; set; }

        public int? nv_escrita { get; set; }

        public int? nv_fala { get; set; }
    }
}
