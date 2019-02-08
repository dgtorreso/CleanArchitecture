namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_os_analista")]
    public partial class cao_os_analista
    {
        [Key]
        public int co_analista { get; set; }

        public int? co_os { get; set; }

        [StringLength(50)]
        public string co_usuario { get; set; }
    }
}
