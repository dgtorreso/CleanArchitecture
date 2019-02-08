namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_cidade")]
    public partial class cao_cidade
    {
        [Key]
        public long co_cidade { get; set; }

        [Required]
        [StringLength(30)]
        public string no_cidade { get; set; }

        public long co_uf { get; set; }
    }
}
