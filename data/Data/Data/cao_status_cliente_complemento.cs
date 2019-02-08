namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_status_cliente_complemento")]
    public partial class cao_status_cliente_complemento
    {
        [Key]
        public long co_complemento_status { get; set; }

        [StringLength(50)]
        public string ds_status { get; set; }

        public long? co_status { get; set; }
    }
}
