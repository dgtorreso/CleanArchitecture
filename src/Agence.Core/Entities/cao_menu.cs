namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_menu")]
    public partial class cao_menu : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte co_menu { get; set; }

        [Required]
        [StringLength(255)]
        public string ds_menu { get; set; }

        [Required]
        [StringLength(255)]
        public string ds_pagina { get; set; }

        [StringLength(255)]
        public string ds_imagem { get; set; }
    }
}
