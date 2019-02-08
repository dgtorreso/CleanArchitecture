namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_formacao_idioma_usuario")]
    public partial class cao_formacao_idioma_usuario
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
