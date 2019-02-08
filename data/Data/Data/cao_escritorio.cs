namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_escritorio")]
    public partial class cao_escritorio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte co_escritorio { get; set; }

        [Required]
        [StringLength(2)]
        public string local { get; set; }
    }
}
