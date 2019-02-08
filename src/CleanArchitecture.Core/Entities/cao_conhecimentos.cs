namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_conhecimentos")]
    public partial class cao_conhecimentos : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cao_conhecimentos()
        {
            cao_conhecimentos_fontes = new HashSet<cao_conhecimentos_fontes>();
            cao_pontos_conhecimento = new HashSet<cao_pontos_conhecimento>();
        }

        [Key]
        public int idconhecimento { get; set; }

        [Required]
        [StringLength(100)]
        public string assunto { get; set; }

        [Required]
        public string conhecimento { get; set; }

        [Required]
        [StringLength(255)]
        public string url { get; set; }

        [Required]
        public string tags { get; set; }

        [Required]
        [StringLength(20)]
        public string usuario { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime datahora { get; set; }

        public virtual cao_usuario cao_usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cao_conhecimentos_fontes> cao_conhecimentos_fontes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cao_pontos_conhecimento> cao_pontos_conhecimento { get; set; }
    }
}
