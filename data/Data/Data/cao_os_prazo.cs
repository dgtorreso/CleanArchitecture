namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_os_prazo")]
    public partial class cao_os_prazo
    {
        [Key]
        public int co_prazo { get; set; }

        public int? co_os { get; set; }

        public long? co_fase { get; set; }

        public int? total_analista { get; set; }

        public int? total_hora { get; set; }
    }
}
