namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_os")]
    public partial class cao_os : Agence.Core.SharedKernel.BaseEntity
    {

        [Key]
        public int co_os { get; set; }


        [StringLength(50)]
        public string co_usuario { get; set; }
        public virtual cao_usuario Cao_Usuario { get; set; }

        public virtual ICollection<cao_fatura> Cao_Faturas { get; set; }

    }
}
