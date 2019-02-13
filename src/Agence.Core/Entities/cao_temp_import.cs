namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_temp_import")]
    public partial class cao_temp_import : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long codigo { get; set; }

        [Required]
        [StringLength(60)]
        public string descricao { get; set; }
    }
}
