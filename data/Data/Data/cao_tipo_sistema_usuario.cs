namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_tipo_sistema_usuario")]
    public partial class cao_tipo_sistema_usuario
    {
        [Key]
        public long co_sistema { get; set; }

        [StringLength(40)]
        public string ds_sistema { get; set; }
    }
}
