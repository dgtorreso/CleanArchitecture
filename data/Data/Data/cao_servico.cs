namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_servico")]
    public partial class cao_servico
    {
        [Key]
        public int co_servico { get; set; }

        [Required]
        [StringLength(50)]
        public string ds_servico { get; set; }
    }
}
