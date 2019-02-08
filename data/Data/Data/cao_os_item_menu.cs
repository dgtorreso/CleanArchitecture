namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_os_item_menu")]
    public partial class cao_os_item_menu
    {
        [Key]
        public int co_item { get; set; }

        [Required]
        [StringLength(255)]
        public string ds_item { get; set; }

        public int co_sistema { get; set; }
    }
}
