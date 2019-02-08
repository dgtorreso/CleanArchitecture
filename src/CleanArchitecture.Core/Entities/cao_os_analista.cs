namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_os_analista")]
    public partial class cao_os_analista : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_analista { get; set; }

        public int? co_os { get; set; }

        [StringLength(50)]
        public string co_usuario { get; set; }
    }
}
