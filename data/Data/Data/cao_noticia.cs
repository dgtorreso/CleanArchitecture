namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_noticia")]
    public partial class cao_noticia
    {
        [Key]
        public int co_noticia { get; set; }

        [Required]
        [StringLength(255)]
        public string assunto { get; set; }

        [Required]
        public string descricao { get; set; }

        [Required]
        [StringLength(255)]
        public string foto { get; set; }

        [Required]
        [StringLength(60)]
        public string co_usuario { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dt_noticia { get; set; }
    }
}
