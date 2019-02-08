namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_tipo_idioma_usuario")]
    public partial class cao_tipo_idioma_usuario
    {
        [Key]
        public int co_idioma { get; set; }

        [StringLength(13)]
        public string ds_idioma { get; set; }
    }
}
