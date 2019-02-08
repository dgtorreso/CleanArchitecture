namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_usuario_dt_disp")]
    public partial class cao_usuario_dt_disp : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [Key]
        public long co_dt_disp { get; set; }

        [StringLength(20)]
        public string co_usuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime dt_disp { get; set; }

        [Column(TypeName = "date")]
        public DateTime dt_alt { get; set; }
    }
}
