namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_rel_email_os")]
    public partial class cao_rel_email_os : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        public int id { get; set; }

        public int co_email { get; set; }

        public int co_os { get; set; }
    }
}
