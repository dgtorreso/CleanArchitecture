namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_horario_almoco")]
    public partial class cao_horario_almoco
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string co_usuario { get; set; }

        [Key]
        [Column(Order = 1)]
        public string almoco_saida_hora { get; set; }

        [Key]
        [Column(Order = 2)]
        public string almoco_volta_hora { get; set; }
    }
}
