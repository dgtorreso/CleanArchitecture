namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_obs_sistema")]
    public partial class cao_obs_sistema : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_obs { get; set; }

        public string descricao { get; set; }

        public long? co_sistema { get; set; }

        [StringLength(20)]
        public string co_usuario { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dt_obs { get; set; }
    }
}
