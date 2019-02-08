namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_tipo_conhecimento_usuario")]
    public partial class cao_tipo_conhecimento_usuario
    {
        [Key]
        public long co_conhecimento { get; set; }

        [StringLength(20)]
        public string ds_conhecimento { get; set; }

        public long co_sistema { get; set; }
    }
}
