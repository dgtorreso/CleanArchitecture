namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_comissao")]
    public partial class cao_comissao : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int co_comissao { get; set; }

        public int co_fatura { get; set; }

        [Column(TypeName = "date")]
        public DateTime dt_efetuado { get; set; }
    }
}
