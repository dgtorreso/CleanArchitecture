namespace CleanArchitecture.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("cao_usuario")]
    public partial class cao_usuario : CleanArchitecture.Core.SharedKernel.BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cao_usuario()
        {
            cao_conhecimentos = new HashSet<cao_conhecimentos>();
            cao_hist_ocorrencias_os = new HashSet<cao_hist_ocorrencias_os>();
            cao_permissao = new HashSet<cao_permissao>();
            cao_salario_pag = new HashSet<cao_salario_pag>();
        }

        [Key]
        [StringLength(20)]
        public string co_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string no_usuario { get; set; }

        [Required]
        [StringLength(14)]
        public string ds_senha { get; set; }

        [StringLength(20)]
        public string co_usuario_autorizacao { get; set; }

        [StringLength(14)]
        public string nu_cpf { get; set; }

        [StringLength(20)]
        public string nu_rg { get; set; }

        [StringLength(10)]
        public string no_orgao_emissor { get; set; }

        [StringLength(2)]
        public string uf_orgao_emissor { get; set; }

        [StringLength(150)]
        public string ds_endereco { get; set; }

        [StringLength(100)]
        public string no_email { get; set; }

        [StringLength(100)]
        public string no_email_pessoal { get; set; }

        [StringLength(64)]
        public string nu_telefone { get; set; }

        [StringLength(255)]
        public string url_foto { get; set; }

        [StringLength(80)]
        public string instant_messenger { get; set; }

        public long? icq { get; set; }

        [StringLength(50)]
        public string msn { get; set; }

        [StringLength(50)]
        public string yms { get; set; }

        [StringLength(50)]
        public string ds_comp_end { get; set; }

        [StringLength(30)]
        public string ds_bairro { get; set; }

        [StringLength(10)]
        public string nu_cep { get; set; }

        [StringLength(50)]
        public string no_cidade { get; set; }

        [StringLength(2)]
        public string uf_cidade { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cao_conhecimentos> cao_conhecimentos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cao_hist_ocorrencias_os> cao_hist_ocorrencias_os { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cao_permissao> cao_permissao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cao_salario_pag> cao_salario_pag { get; set; }

        public virtual ICollection<cao_sistema> Cao_Sistemas { get; set; }
        public virtual ICollection<cao_os> Cao_Os { get; set; }
        public virtual ICollection<permissao_sistema> permissao_sistema { get; set; }
        public virtual ICollection<cao_salario> Cao_Salarios { get; set; }
    }
}
