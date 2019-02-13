namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_salario")]
    public partial class cao_salario : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_usuario { get; set; }
        public virtual cao_usuario Cao_Usuario { get; set; }
        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime dt_alteracao { get; set; }

        public float brut_salario { get; set; }

        public float liq_salario { get; set; }
    }
}
