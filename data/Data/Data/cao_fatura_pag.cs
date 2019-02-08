namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_fatura_pag")]
    public partial class cao_fatura_pag
    {
        [Key]
        public int id_fatura_pag { get; set; }

        public int co_fatura { get; set; }

        [Column(TypeName = "date")]
        public DateTime dt_efetuado { get; set; }

        public float valor_pago { get; set; }
    }
}
