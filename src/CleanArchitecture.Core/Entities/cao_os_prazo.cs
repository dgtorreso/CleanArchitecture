namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_os_prazo")]
    public partial class cao_os_prazo : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_prazo { get; set; }

        public int? co_os { get; set; }

        public long? co_fase { get; set; }

        public int? total_analista { get; set; }

        public int? total_hora { get; set; }
    }
}
