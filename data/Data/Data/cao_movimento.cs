namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_movimento")]
    public partial class cao_movimento
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal co_movimento { get; set; }

        [Required]
        [StringLength(50)]
        public string co_usuario { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dt_entrada { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dt_saida_almoco { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dt_volta_almoco { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dt_saida { get; set; }

        public byte is_encerrado { get; set; }
    }
}
