namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_temp_import")]
    public partial class cao_temp_import
    {
        [Key]
        public long codigo { get; set; }

        [Required]
        [StringLength(60)]
        public string descricao { get; set; }
    }
}
