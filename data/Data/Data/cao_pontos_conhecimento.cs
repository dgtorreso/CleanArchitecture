namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_pontos_conhecimento")]
    public partial class cao_pontos_conhecimento
    {
        [Key]
        public int idpontos { get; set; }

        public short pontuacao { get; set; }

        [Required]
        [StringLength(50)]
        public string co_coordenador { get; set; }

        public int idconhecimento { get; set; }

        public virtual cao_conhecimentos cao_conhecimentos { get; set; }

        public virtual cao_escala_ranking cao_escala_ranking { get; set; }
    }
}
