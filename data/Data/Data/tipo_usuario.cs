namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.tipo_usuario")]
    public partial class tipo_usuario
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal co_tipo_usuario { get; set; }

        [Required]
        [StringLength(32)]
        public string ds_tipo_usuario { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal co_sistema { get; set; }
    }
}
