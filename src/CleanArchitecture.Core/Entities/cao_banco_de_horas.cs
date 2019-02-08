namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_banco_de_horas")]
    public partial class cao_banco_de_horas : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string co_usuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_cadastro { get; set; }

        public int segundos { get; set; }

        [Required]
        [StringLength(10)]
        public string tipo { get; set; }
    }
}
