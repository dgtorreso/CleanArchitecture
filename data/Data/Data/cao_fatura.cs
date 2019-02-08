namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_fatura")]
    public partial class cao_fatura
    {
        [Key]
        public long co_fatura { get; set; }

        public int co_cliente { get; set; }

        public int co_sistema { get; set; }

        public int co_os { get; set; }

        public int num_nf { get; set; }

        public float total { get; set; }

        public float valor { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_emissao { get; set; }

        [Required]
        public string corpo_nf { get; set; }

        public float comissao_cn { get; set; }

        public float total_imp_inc { get; set; }
    }
}
