namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("caol.cao_rel_email_os")]
    public partial class cao_rel_email_os
    {
        public int id { get; set; }

        public int co_email { get; set; }

        public int co_os { get; set; }
    }
}
