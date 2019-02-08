namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_help_tela_chamado")]
    public partial class cao_help_tela_chamado
    {
        [Key]
        public int co_tela { get; set; }

        public int co_cliente { get; set; }

        public int co_sistema { get; set; }

        [Required]
        [StringLength(200)]
        public string ds_tela { get; set; }
    }
}
