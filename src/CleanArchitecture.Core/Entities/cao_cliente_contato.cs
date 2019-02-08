namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_cliente_contato")]
    public partial class cao_cliente_contato : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long co_cliente { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dt_contato { get; set; }

        public long? fg_agendado { get; set; }

        public TimeSpan? hr_ini { get; set; }

        public TimeSpan? hr_end { get; set; }
    }
}
