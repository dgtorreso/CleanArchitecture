namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_os_chamado")]
    public partial class cao_os_chamado
    {
        [Key]
        public int co_chamado { get; set; }

        public int co_sistema { get; set; }

        public int co_os { get; set; }

        [Required]
        [StringLength(255)]
        public string ds_chamado { get; set; }

        public int co_tipo { get; set; }

        public int co_prioridade { get; set; }

        public int co_item { get; set; }

        [Required]
        public string descricao { get; set; }

        [Required]
        public string ds_solucao { get; set; }

        [Required]
        [StringLength(30)]
        public string tempo { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dt_chamado { get; set; }

        public int status { get; set; }

        [Required]
        [StringLength(255)]
        public string co_usuario { get; set; }

        [Required]
        [StringLength(255)]
        public string co_analista { get; set; }

        [StringLength(255)]
        public string email { get; set; }
    }
}
