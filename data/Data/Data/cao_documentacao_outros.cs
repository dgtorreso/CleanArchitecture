namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_documentacao_outros")]
    public partial class cao_documentacao_outros
    {
        public int id { get; set; }

        [Required]
        [StringLength(70)]
        public string nome { get; set; }

        public int co_sistema { get; set; }
    }
}
