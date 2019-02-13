namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_salario_pag")]
    public partial class cao_salario_pag : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        public int id_pagamento { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string co_usuario { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime dt_efetuado { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string status { get; set; }

        public string observacao { get; set; }

        public virtual cao_usuario cao_usuario { get; set; }
    }
}
