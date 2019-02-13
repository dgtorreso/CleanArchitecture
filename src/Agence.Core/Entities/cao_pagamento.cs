namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_pagamento")]
    public partial class cao_pagamento : Agence.Core.SharedKernel.BaseEntity
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal co_pagamento { get; set; }

        [Required]
        [StringLength(20)]
        public string co_usuario { get; set; }

        [Required]
        [StringLength(2)]
        public string tp_pagamento { get; set; }

        [Column(TypeName = "date")]
        public DateTime dt_pagamento { get; set; }

        public float vl_pagamento { get; set; }

        [Column(TypeName = "date")]
        public DateTime dt_referencia_pagamento { get; set; }
    }
}
