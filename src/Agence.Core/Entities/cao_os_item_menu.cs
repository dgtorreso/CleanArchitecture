namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_os_item_menu")]
    public partial class cao_os_item_menu : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_item { get; set; }

        [Required]
        [StringLength(255)]
        public string ds_item { get; set; }

        public int co_sistema { get; set; }
    }
}
