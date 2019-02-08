namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_os_obs")]
    public partial class cao_os_obs : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_obs { get; set; }

        public int? co_os { get; set; }

        [StringLength(80)]
        public string co_usuario { get; set; }

        public string descricao { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dt_obs { get; set; }
    }
}
