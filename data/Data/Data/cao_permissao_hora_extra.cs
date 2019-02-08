namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_permissao_hora_extra")]
    public partial class cao_permissao_hora_extra
    {
        [Key]
        public int id_permissao { get; set; }

        public long co_movimento { get; set; }
    }
}
