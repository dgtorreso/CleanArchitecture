namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_formacao_usuario")]
    public partial class cao_formacao_usuario
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_usuario { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(13)]
        public string tp_curso { get; set; }

        [StringLength(50)]
        public string ds_curso { get; set; }

        [StringLength(50)]
        public string ds_instituicao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dt_conclusao { get; set; }
    }
}
