namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_escritorio")]
    public partial class cao_escritorio : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte co_escritorio { get; set; }

        [Required]
        [StringLength(2)]
        public string local { get; set; }
    }
}
