namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_status_os")]
    public partial class cao_status_os
    {
        [Key]
        public long co_status_atual { get; set; }

        [Required]
        [StringLength(50)]
        public string ds_status { get; set; }
    }
}
