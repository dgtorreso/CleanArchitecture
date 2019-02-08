namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_aviso")]
    public partial class cao_aviso
    {
        [Key]
        public long co_aviso { get; set; }

        [Required]
        public string ds_aviso { get; set; }
    }
}
