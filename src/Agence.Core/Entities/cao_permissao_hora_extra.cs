namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_permissao_hora_extra")]
    public partial class cao_permissao_hora_extra : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        public int id_permissao { get; set; }

        public long co_movimento { get; set; }
    }
}
