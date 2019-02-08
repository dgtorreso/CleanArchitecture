namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_atividade_teste")]
    public partial class cao_atividade_teste
    {
        [Key]
        public int co_atividade { get; set; }

        [Required]
        [StringLength(30)]
        public string ds_atividade { get; set; }

        public long co_tipo_usuario { get; set; }
    }
}
