namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_os_fase")]
    public partial class cao_os_fase
    {
        [Key]
        public int co_fase { get; set; }

        [StringLength(200)]
        public string descricao { get; set; }

        [Required]
        [StringLength(200)]
        public string descricao_ingl { get; set; }

        public int? ordem { get; set; }
    }
}
