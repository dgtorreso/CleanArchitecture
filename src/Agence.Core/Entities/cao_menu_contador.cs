namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_menu_contador")]
    public partial class cao_menu_contador : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_usuario { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte co_menu { get; set; }

        public short nu_pontos { get; set; }

        public byte in_processado { get; set; }
    }
}
