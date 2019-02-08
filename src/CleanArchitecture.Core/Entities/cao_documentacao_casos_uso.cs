namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_documentacao_casos_uso")]
    public partial class cao_documentacao_casos_uso : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        public int id { get; set; }

        [Required]
        [StringLength(70)]
        public string nome { get; set; }

        public int co_sistema { get; set; }
    }
}
