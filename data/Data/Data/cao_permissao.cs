namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_permissao")]
    public partial class cao_permissao
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_usuario { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string permissao_intervalo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string permissao_hora_extra { get; set; }

        public virtual cao_usuario cao_usuario { get; set; }
    }
}
