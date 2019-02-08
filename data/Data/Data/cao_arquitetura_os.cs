namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_arquitetura_os")]
    public partial class cao_arquitetura_os
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long co_arquitetura { get; set; }

        [Required]
        [StringLength(20)]
        public string ds_arquitetura { get; set; }
    }
}
