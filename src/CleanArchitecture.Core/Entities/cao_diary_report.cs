namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_diary_report")]
    public partial class cao_diary_report : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_diary_report { get; set; }

        public TimeSpan? hr_gasta { get; set; }

        public int co_atividade { get; set; }

        [Required]
        public string ds_assunto { get; set; }

        public long co_movimento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? nu_os { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? co_sistema { get; set; }
    }
}
