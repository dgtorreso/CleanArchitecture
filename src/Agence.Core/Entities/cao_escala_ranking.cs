namespace Agence.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_escala_ranking")]
    public partial class cao_escala_ranking : Agence.Core.SharedKernel.BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cao_escala_ranking()
        {
            cao_pontos_conhecimento = new HashSet<cao_pontos_conhecimento>();
        }

        [Key]
        public short idescala { get; set; }

        public short qtd_visual { get; set; }

        public int pontuacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cao_pontos_conhecimento> cao_pontos_conhecimento { get; set; }
    }
}
