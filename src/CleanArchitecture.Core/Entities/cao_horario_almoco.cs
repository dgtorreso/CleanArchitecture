namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_horario_almoco")]
    public partial class cao_horario_almoco : CleanArchitecture.Core.SharedKernel.BaseEntity
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
