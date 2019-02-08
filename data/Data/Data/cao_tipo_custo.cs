namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_tipo_custo")]
    public partial class cao_tipo_custo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte co_tipo_custo { get; set; }

        [Required]
        [StringLength(30)]
        public string descricao { get; set; }
    }
}
