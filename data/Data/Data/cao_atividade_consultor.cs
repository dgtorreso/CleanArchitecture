namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_atividade_consultor")]
    public partial class cao_atividade_consultor
    {
        [Key]
        public int co_atividade { get; set; }

        [Required]
        [StringLength(50)]
        public string ds_atividade { get; set; }

        [StringLength(1)]
        public string ativo { get; set; }
    }
}
