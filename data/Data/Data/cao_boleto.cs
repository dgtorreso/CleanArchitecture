namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_boleto")]
    public partial class cao_boleto
    {
        [Key]
        public int co_boleto { get; set; }

        public int co_cliente { get; set; }

        public int co_sistema { get; set; }

        public int co_os { get; set; }

        [Required]
        [StringLength(128)]
        public string valor { get; set; }

        [Required]
        [StringLength(128)]
        public string vencimento { get; set; }

        public int status { get; set; }

        [StringLength(255)]
        public string boleto { get; set; }

        [StringLength(255)]
        public string linha_dig { get; set; }

        [StringLength(20)]
        public string parcela { get; set; }
    }
}
