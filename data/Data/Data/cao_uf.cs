namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_uf")]
    public partial class cao_uf
    {
        [Key]
        public long co_uf { get; set; }

        [Required]
        [StringLength(5)]
        public string ds_uf { get; set; }
    }
}
