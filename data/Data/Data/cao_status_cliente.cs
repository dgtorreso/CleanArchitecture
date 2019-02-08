namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_status_cliente")]
    public partial class cao_status_cliente
    {
        [Key]
        public long co_status { get; set; }

        [Required]
        [StringLength(100)]
        public string ds_status { get; set; }
    }
}
