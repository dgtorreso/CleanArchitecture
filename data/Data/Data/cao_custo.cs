namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_custo")]
    public partial class cao_custo
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal co_custo { get; set; }

        public short co_tipo_custo { get; set; }

        [Required]
        [StringLength(100)]
        public string descricao { get; set; }

        public short co_escritorio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dt_compra { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dt_pagamento { get; set; }

        public string co_boleto { get; set; }

        public float valor { get; set; }

        [StringLength(5)]
        public string parcela { get; set; }

        public short? pag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal co_custo_high { get; set; }
    }
}
