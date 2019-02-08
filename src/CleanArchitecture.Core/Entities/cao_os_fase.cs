namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_os_fase")]
    public partial class cao_os_fase : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_fase { get; set; }

        [StringLength(200)]
        public string descricao { get; set; }

        [Required]
        [StringLength(200)]
        public string descricao_ingl { get; set; }

        public int? ordem { get; set; }
    }
}
