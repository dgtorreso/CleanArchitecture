namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_categorias_ombudsman")]
    public partial class cao_categorias_ombudsman : Agence.Core.SharedKernel.BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cao_categorias_ombudsman()
        {
            cao_ombudsman = new HashSet<cao_ombudsman>();
        }

        [Key]
        public short idcategoria { get; set; }

        [Required]
        [StringLength(100)]
        public string descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cao_ombudsman> cao_ombudsman { get; set; }
    }
}
