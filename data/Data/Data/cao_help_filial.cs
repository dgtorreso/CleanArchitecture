namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_help_filial")]
    public partial class cao_help_filial
    {
        [Key]
        public long co_filial { get; set; }

        [Required]
        [StringLength(70)]
        public string no_filial { get; set; }

        public int co_cliente { get; set; }

        [Required]
        [StringLength(2)]
        public string estado { get; set; }
    }
}
