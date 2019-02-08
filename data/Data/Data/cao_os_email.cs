namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_os_email")]
    public partial class cao_os_email
    {
        [Key]
        public int co_email { get; set; }

        public int? co_os { get; set; }

        [StringLength(200)]
        public string email { get; set; }

        [StringLength(20)]
        public string senha { get; set; }

        [Required]
        [StringLength(255)]
        public string nome { get; set; }

        public int co_cliente { get; set; }

        public int ativo { get; set; }

        [StringLength(20)]
        public string ddd { get; set; }

        [StringLength(40)]
        public string tel { get; set; }

        [StringLength(80)]
        public string cargo { get; set; }
    }
}
