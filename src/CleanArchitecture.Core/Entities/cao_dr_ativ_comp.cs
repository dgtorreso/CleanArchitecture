namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_dr_ativ_comp")]
    public partial class cao_dr_ativ_comp : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int id_ativ_comp { get; set; }

        [Required]
        [StringLength(20)]
        public string co_usuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        [Required]
        public string assunto { get; set; }

        public TimeSpan tempo_gasto { get; set; }
    }
}
