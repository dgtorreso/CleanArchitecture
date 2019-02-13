namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_arquitetura_os")]
    public partial class cao_arquitetura_os : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long co_arquitetura { get; set; }

        [Required]
        [StringLength(20)]
        public string ds_arquitetura { get; set; }
    }
}
