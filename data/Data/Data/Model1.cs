namespace Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Caol")
        {
        }

        public virtual DbSet<cao_acompanhamento_sistema> cao_acompanhamento_sistema { get; set; }
        public virtual DbSet<cao_agendamento> cao_agendamento { get; set; }
        public virtual DbSet<cao_arquitetura_os> cao_arquitetura_os { get; set; }
        public virtual DbSet<cao_atividade> cao_atividade { get; set; }
        public virtual DbSet<cao_atividade_consultor> cao_atividade_consultor { get; set; }
        public virtual DbSet<cao_atividade_report> cao_atividade_report { get; set; }
        public virtual DbSet<cao_atividade_teste> cao_atividade_teste { get; set; }
        public virtual DbSet<cao_aviso> cao_aviso { get; set; }
        public virtual DbSet<cao_banco_de_horas> cao_banco_de_horas { get; set; }
        public virtual DbSet<cao_banco_horas> cao_banco_horas { get; set; }
        public virtual DbSet<cao_boleto> cao_boleto { get; set; }
        public virtual DbSet<cao_bonus> cao_bonus { get; set; }
        public virtual DbSet<cao_bonus_status> cao_bonus_status { get; set; }
        public virtual DbSet<cao_categorias_ombudsman> cao_categorias_ombudsman { get; set; }
        public virtual DbSet<cao_cidade> cao_cidade { get; set; }
        public virtual DbSet<cao_cliente> cao_cliente { get; set; }
        public virtual DbSet<cao_cliente_contato> cao_cliente_contato { get; set; }
        public virtual DbSet<cao_comissao> cao_comissao { get; set; }
        public virtual DbSet<cao_complemento> cao_complemento { get; set; }
        public virtual DbSet<cao_conhecimento_usuario> cao_conhecimento_usuario { get; set; }
        public virtual DbSet<cao_conhecimentos> cao_conhecimentos { get; set; }
        public virtual DbSet<cao_conhecimentos_fontes> cao_conhecimentos_fontes { get; set; }
        public virtual DbSet<cao_custo> cao_custo { get; set; }
        public virtual DbSet<cao_diary_report> cao_diary_report { get; set; }
        public virtual DbSet<cao_diary_report_consultor> cao_diary_report_consultor { get; set; }
        public virtual DbSet<cao_documentacao_casos_uso> cao_documentacao_casos_uso { get; set; }
        public virtual DbSet<cao_documentacao_outros> cao_documentacao_outros { get; set; }
        public virtual DbSet<cao_documentacao_sistema> cao_documentacao_sistema { get; set; }
        public virtual DbSet<cao_dr_ativ_comp> cao_dr_ativ_comp { get; set; }
        public virtual DbSet<cao_escala_ranking> cao_escala_ranking { get; set; }
        public virtual DbSet<cao_escritorio> cao_escritorio { get; set; }
        public virtual DbSet<cao_fatura> cao_fatura { get; set; }
        public virtual DbSet<cao_fatura_pag> cao_fatura_pag { get; set; }
        public virtual DbSet<cao_formacao_idioma_usuario> cao_formacao_idioma_usuario { get; set; }
        public virtual DbSet<cao_formacao_usuario> cao_formacao_usuario { get; set; }
        public virtual DbSet<cao_help_autor> cao_help_autor { get; set; }
        public virtual DbSet<cao_help_chamado> cao_help_chamado { get; set; }
        public virtual DbSet<cao_help_filial> cao_help_filial { get; set; }
        public virtual DbSet<cao_help_motivo_chamado> cao_help_motivo_chamado { get; set; }
        public virtual DbSet<cao_help_status_chamado> cao_help_status_chamado { get; set; }
        public virtual DbSet<cao_help_tela_chamado> cao_help_tela_chamado { get; set; }
        public virtual DbSet<cao_hist_ocorrencias_os> cao_hist_ocorrencias_os { get; set; }
        public virtual DbSet<cao_log_chamado> cao_log_chamado { get; set; }
        public virtual DbSet<cao_menu> cao_menu { get; set; }
        public virtual DbSet<cao_menu_contador> cao_menu_contador { get; set; }
        public virtual DbSet<cao_movimento> cao_movimento { get; set; }
        public virtual DbSet<cao_movimento_justificativa> cao_movimento_justificativa { get; set; }
        public virtual DbSet<cao_movimento_os> cao_movimento_os { get; set; }
        public virtual DbSet<cao_noticia> cao_noticia { get; set; }
        public virtual DbSet<cao_obs_cliente> cao_obs_cliente { get; set; }
        public virtual DbSet<cao_obs_sistema> cao_obs_sistema { get; set; }
        public virtual DbSet<cao_ombudsman> cao_ombudsman { get; set; }
        public virtual DbSet<cao_os> cao_os { get; set; }
        public virtual DbSet<cao_os_analista> cao_os_analista { get; set; }
        public virtual DbSet<cao_os_chamado> cao_os_chamado { get; set; }
        public virtual DbSet<cao_os_daily_report> cao_os_daily_report { get; set; }
        public virtual DbSet<cao_os_email> cao_os_email { get; set; }
        public virtual DbSet<cao_os_fase> cao_os_fase { get; set; }
        public virtual DbSet<cao_os_item_menu> cao_os_item_menu { get; set; }
        public virtual DbSet<cao_os_obs> cao_os_obs { get; set; }
        public virtual DbSet<cao_os_obs_chamado> cao_os_obs_chamado { get; set; }
        public virtual DbSet<cao_os_prazo> cao_os_prazo { get; set; }
        public virtual DbSet<cao_os_status> cao_os_status { get; set; }
        public virtual DbSet<cao_pagamento> cao_pagamento { get; set; }
        public virtual DbSet<cao_participacao_funcionario> cao_participacao_funcionario { get; set; }
        public virtual DbSet<cao_permissao_hora_extra> cao_permissao_hora_extra { get; set; }
        public virtual DbSet<cao_pontos_conhecimento> cao_pontos_conhecimento { get; set; }
        public virtual DbSet<cao_ramo> cao_ramo { get; set; }
        public virtual DbSet<cao_rel_email_os> cao_rel_email_os { get; set; }
        public virtual DbSet<cao_salario> cao_salario { get; set; }
        public virtual DbSet<cao_servico> cao_servico { get; set; }
        public virtual DbSet<cao_sistema> cao_sistema { get; set; }
        public virtual DbSet<cao_sistema_obs> cao_sistema_obs { get; set; }
        public virtual DbSet<cao_status_agendamento> cao_status_agendamento { get; set; }
        public virtual DbSet<cao_status_cliente> cao_status_cliente { get; set; }
        public virtual DbSet<cao_status_cliente_complemento> cao_status_cliente_complemento { get; set; }
        public virtual DbSet<cao_status_os> cao_status_os { get; set; }
        public virtual DbSet<cao_temp_import> cao_temp_import { get; set; }
        public virtual DbSet<cao_tipo_conhecimento_usuario> cao_tipo_conhecimento_usuario { get; set; }
        public virtual DbSet<cao_tipo_custo> cao_tipo_custo { get; set; }
        public virtual DbSet<cao_tipo_idioma_usuario> cao_tipo_idioma_usuario { get; set; }
        public virtual DbSet<cao_tipo_ombudsman> cao_tipo_ombudsman { get; set; }
        public virtual DbSet<cao_tipo_sistema_usuario> cao_tipo_sistema_usuario { get; set; }
        public virtual DbSet<cao_uf> cao_uf { get; set; }
        public virtual DbSet<cao_usuario> cao_usuario { get; set; }
        public virtual DbSet<cao_usuario_dt_disp> cao_usuario_dt_disp { get; set; }
        public virtual DbSet<cao_valor_descanso> cao_valor_descanso { get; set; }
        public virtual DbSet<permissao_sistema> permissao_sistema { get; set; }
        public virtual DbSet<tipo_usuario> tipo_usuario { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<cao_horario_almoco> cao_horario_almoco { get; set; }
        public virtual DbSet<cao_permissao> cao_permissao { get; set; }
        public virtual DbSet<cao_salario_pag> cao_salario_pag { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cao_acompanhamento_sistema>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<cao_acompanhamento_sistema>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<cao_acompanhamento_sistema>()
                .Property(e => e.status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cao_agendamento>()
                .Property(e => e.dt_hr_inicio)
                .HasPrecision(0);

            modelBuilder.Entity<cao_agendamento>()
                .Property(e => e.dt_hr_fim)
                .HasPrecision(0);

            modelBuilder.Entity<cao_arquitetura_os>()
                .Property(e => e.ds_arquitetura)
                .IsUnicode(false);

            modelBuilder.Entity<cao_atividade>()
                .Property(e => e.ds_atividade)
                .IsUnicode(false);

            modelBuilder.Entity<cao_atividade_consultor>()
                .Property(e => e.ds_atividade)
                .IsUnicode(false);

            modelBuilder.Entity<cao_atividade_consultor>()
                .Property(e => e.ativo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cao_atividade_report>()
                .Property(e => e.inicio)
                .IsUnicode(false);

            modelBuilder.Entity<cao_atividade_report>()
                .Property(e => e.fim)
                .IsUnicode(false);

            modelBuilder.Entity<cao_atividade_report>()
                .Property(e => e.lembrete)
                .IsUnicode(false);

            modelBuilder.Entity<cao_atividade_report>()
                .Property(e => e.assunto)
                .IsUnicode(false);

            modelBuilder.Entity<cao_atividade_report>()
                .Property(e => e.conteudo)
                .IsUnicode(false);

            modelBuilder.Entity<cao_atividade_report>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<cao_atividade_report>()
                .Property(e => e.tempo)
                .IsUnicode(false);

            modelBuilder.Entity<cao_atividade_report>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_atividade_report>()
                .Property(e => e.data_ativ)
                .HasPrecision(0);

            modelBuilder.Entity<cao_atividade_report>()
                .Property(e => e.retorno)
                .IsUnicode(false);

            modelBuilder.Entity<cao_atividade_teste>()
                .Property(e => e.ds_atividade)
                .IsUnicode(false);

            modelBuilder.Entity<cao_aviso>()
                .Property(e => e.ds_aviso)
                .IsUnicode(false);

            modelBuilder.Entity<cao_banco_horas>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_banco_horas>()
                .Property(e => e.periodo)
                .IsUnicode(false);

            modelBuilder.Entity<cao_boleto>()
                .Property(e => e.valor)
                .IsUnicode(false);

            modelBuilder.Entity<cao_boleto>()
                .Property(e => e.vencimento)
                .IsUnicode(false);

            modelBuilder.Entity<cao_boleto>()
                .Property(e => e.boleto)
                .IsUnicode(false);

            modelBuilder.Entity<cao_boleto>()
                .Property(e => e.linha_dig)
                .IsUnicode(false);

            modelBuilder.Entity<cao_boleto>()
                .Property(e => e.parcela)
                .IsUnicode(false);

            modelBuilder.Entity<cao_bonus_status>()
                .Property(e => e.mes)
                .IsUnicode(false);

            modelBuilder.Entity<cao_bonus_status>()
                .Property(e => e.valor)
                .IsUnicode(false);

            modelBuilder.Entity<cao_bonus_status>()
                .Property(e => e.is_solic)
                .IsUnicode(false);

            modelBuilder.Entity<cao_bonus_status>()
                .Property(e => e.is_pg)
                .IsUnicode(false);

            modelBuilder.Entity<cao_bonus_status>()
                .Property(e => e.is_horas)
                .IsUnicode(false);

            modelBuilder.Entity<cao_categorias_ombudsman>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_categorias_ombudsman>()
                .HasMany(e => e.cao_ombudsman)
                .WithRequired(e => e.cao_categorias_ombudsman)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cao_cidade>()
                .Property(e => e.no_cidade)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.no_razao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.no_fantasia)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.no_contato)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.nu_telefone)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.nu_ramal)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.nu_cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.ds_endereco)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.ds_complemento)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.no_bairro)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.nu_cep)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.no_pais)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.ds_site)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.ds_email)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.ds_cargo_contato)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.tp_cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.ds_referencia)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.nu_fax)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.ddd2)
                .IsUnicode(false);

            modelBuilder.Entity<cao_cliente>()
                .Property(e => e.telefone2)
                .IsUnicode(false);

            modelBuilder.Entity<cao_complemento>()
                .Property(e => e.ds_complemento)
                .IsUnicode(false);

            modelBuilder.Entity<cao_conhecimento_usuario>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_conhecimentos>()
                .Property(e => e.assunto)
                .IsUnicode(false);

            modelBuilder.Entity<cao_conhecimentos>()
                .Property(e => e.conhecimento)
                .IsUnicode(false);

            modelBuilder.Entity<cao_conhecimentos>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<cao_conhecimentos>()
                .Property(e => e.tags)
                .IsUnicode(false);

            modelBuilder.Entity<cao_conhecimentos>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_conhecimentos>()
                .Property(e => e.datahora)
                .HasPrecision(0);

            modelBuilder.Entity<cao_conhecimentos>()
                .HasMany(e => e.cao_conhecimentos_fontes)
                .WithRequired(e => e.cao_conhecimentos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cao_conhecimentos>()
                .HasMany(e => e.cao_pontos_conhecimento)
                .WithRequired(e => e.cao_conhecimentos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cao_conhecimentos_fontes>()
                .Property(e => e.datahora)
                .HasPrecision(0);

            modelBuilder.Entity<cao_conhecimentos_fontes>()
                .Property(e => e.arquivo)
                .IsUnicode(false);

            modelBuilder.Entity<cao_conhecimentos_fontes>()
                .Property(e => e.caminho)
                .IsUnicode(false);

            modelBuilder.Entity<cao_custo>()
                .Property(e => e.co_custo)
                .HasPrecision(20, 0);

            modelBuilder.Entity<cao_custo>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_custo>()
                .Property(e => e.co_boleto)
                .IsUnicode(false);

            modelBuilder.Entity<cao_custo>()
                .Property(e => e.parcela)
                .IsUnicode(false);

            modelBuilder.Entity<cao_custo>()
                .Property(e => e.co_custo_high)
                .HasPrecision(20, 0);

            modelBuilder.Entity<cao_diary_report>()
                .Property(e => e.ds_assunto)
                .IsUnicode(false);

            modelBuilder.Entity<cao_diary_report>()
                .Property(e => e.nu_os)
                .HasPrecision(20, 0);

            modelBuilder.Entity<cao_diary_report>()
                .Property(e => e.co_sistema)
                .HasPrecision(20, 0);

            modelBuilder.Entity<cao_diary_report_consultor>()
                .Property(e => e.ds_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<cao_diary_report_consultor>()
                .Property(e => e.ds_assunto)
                .IsUnicode(false);

            modelBuilder.Entity<cao_diary_report_consultor>()
                .Property(e => e.dt_agendamento)
                .HasPrecision(0);

            modelBuilder.Entity<cao_diary_report_consultor>()
                .Property(e => e.dt_agendamento_fim)
                .HasPrecision(0);

            modelBuilder.Entity<cao_documentacao_casos_uso>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<cao_documentacao_outros>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<cao_documentacao_sistema>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_documentacao_sistema>()
                .Property(e => e.pasta)
                .IsUnicode(false);

            modelBuilder.Entity<cao_documentacao_sistema>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_documentacao_sistema>()
                .Property(e => e.dt_doc)
                .HasPrecision(0);

            modelBuilder.Entity<cao_documentacao_sistema>()
                .Property(e => e.arquivo)
                .IsUnicode(false);

            modelBuilder.Entity<cao_dr_ativ_comp>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_dr_ativ_comp>()
                .Property(e => e.assunto)
                .IsUnicode(false);

            modelBuilder.Entity<cao_escala_ranking>()
                .HasMany(e => e.cao_pontos_conhecimento)
                .WithRequired(e => e.cao_escala_ranking)
                .HasForeignKey(e => e.pontuacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cao_escritorio>()
                .Property(e => e.local)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cao_fatura>()
                .Property(e => e.corpo_nf)
                .IsUnicode(false);

            modelBuilder.Entity<cao_formacao_idioma_usuario>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_formacao_usuario>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_formacao_usuario>()
                .Property(e => e.tp_curso)
                .IsUnicode(false);

            modelBuilder.Entity<cao_formacao_usuario>()
                .Property(e => e.ds_curso)
                .IsUnicode(false);

            modelBuilder.Entity<cao_formacao_usuario>()
                .Property(e => e.ds_instituicao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_autor>()
                .Property(e => e.no_autor)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_autor>()
                .Property(e => e.nu_ddd1)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_autor>()
                .Property(e => e.nu_tel1)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_autor>()
                .Property(e => e.nu_ramal1)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_autor>()
                .Property(e => e.nu_ddd2)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_autor>()
                .Property(e => e.nu_tel2)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_autor>()
                .Property(e => e.nu_ramal2)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_autor>()
                .Property(e => e.ds_email)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_autor>()
                .Property(e => e.ds_funcao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_chamado>()
                .Property(e => e.ds_chamado)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_chamado>()
                .Property(e => e.ds_solucao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_filial>()
                .Property(e => e.no_filial)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_filial>()
                .Property(e => e.estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_motivo_chamado>()
                .Property(e => e.ds_motivo)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_status_chamado>()
                .Property(e => e.ds_status)
                .IsUnicode(false);

            modelBuilder.Entity<cao_help_tela_chamado>()
                .Property(e => e.ds_tela)
                .IsUnicode(false);

            modelBuilder.Entity<cao_hist_ocorrencias_os>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_hist_ocorrencias_os>()
                .Property(e => e.data)
                .HasPrecision(0);

            modelBuilder.Entity<cao_hist_ocorrencias_os>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<cao_hist_ocorrencias_os>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_hist_ocorrencias_os>()
                .Property(e => e.responsavel)
                .IsUnicode(false);

            modelBuilder.Entity<cao_hist_ocorrencias_os>()
                .Property(e => e.data_fechamento)
                .HasPrecision(0);

            modelBuilder.Entity<cao_log_chamado>()
                .Property(e => e.dt_chamado)
                .HasPrecision(0);

            modelBuilder.Entity<cao_log_chamado>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_menu>()
                .Property(e => e.ds_menu)
                .IsUnicode(false);

            modelBuilder.Entity<cao_menu>()
                .Property(e => e.ds_pagina)
                .IsUnicode(false);

            modelBuilder.Entity<cao_menu>()
                .Property(e => e.ds_imagem)
                .IsUnicode(false);

            modelBuilder.Entity<cao_menu_contador>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_movimento>()
                .Property(e => e.co_movimento)
                .HasPrecision(20, 0);

            modelBuilder.Entity<cao_movimento>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_movimento>()
                .Property(e => e.dt_entrada)
                .HasPrecision(0);

            modelBuilder.Entity<cao_movimento>()
                .Property(e => e.dt_saida_almoco)
                .HasPrecision(0);

            modelBuilder.Entity<cao_movimento>()
                .Property(e => e.dt_volta_almoco)
                .HasPrecision(0);

            modelBuilder.Entity<cao_movimento>()
                .Property(e => e.dt_saida)
                .HasPrecision(0);

            modelBuilder.Entity<cao_movimento_justificativa>()
                .Property(e => e.co_movimento_justificativa)
                .HasPrecision(20, 0);

            modelBuilder.Entity<cao_movimento_justificativa>()
                .Property(e => e.co_movimento)
                .HasPrecision(20, 0);

            modelBuilder.Entity<cao_movimento_justificativa>()
                .Property(e => e.nu_os)
                .HasPrecision(20, 0);

            modelBuilder.Entity<cao_movimento_justificativa>()
                .Property(e => e.ds_justificativa)
                .IsUnicode(false);

            modelBuilder.Entity<cao_movimento_os>()
                .Property(e => e.ds_valor)
                .IsUnicode(false);

            modelBuilder.Entity<cao_movimento_os>()
                .Property(e => e.usuario_obs)
                .IsUnicode(false);

            modelBuilder.Entity<cao_movimento_os>()
                .Property(e => e.dt_ini)
                .HasPrecision(0);

            modelBuilder.Entity<cao_movimento_os>()
                .Property(e => e.dt_fim)
                .HasPrecision(0);

            modelBuilder.Entity<cao_noticia>()
                .Property(e => e.assunto)
                .IsUnicode(false);

            modelBuilder.Entity<cao_noticia>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_noticia>()
                .Property(e => e.foto)
                .IsUnicode(false);

            modelBuilder.Entity<cao_noticia>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_noticia>()
                .Property(e => e.dt_noticia)
                .HasPrecision(0);

            modelBuilder.Entity<cao_obs_cliente>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_obs_cliente>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_obs_cliente>()
                .Property(e => e.dt_obs)
                .HasPrecision(0);

            modelBuilder.Entity<cao_obs_sistema>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_obs_sistema>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_obs_sistema>()
                .Property(e => e.dt_obs)
                .HasPrecision(0);

            modelBuilder.Entity<cao_ombudsman>()
                .Property(e => e.data)
                .HasPrecision(0);

            modelBuilder.Entity<cao_ombudsman>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os>()
                .Property(e => e.ds_os)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os>()
                .Property(e => e.ds_caracteristica)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os>()
                .Property(e => e.ds_requisito)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os>()
                .Property(e => e.diretoria_sol)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os>()
                .Property(e => e.nu_tel_sol)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os>()
                .Property(e => e.ddd_tel_sol)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os>()
                .Property(e => e.nu_tel_sol2)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os>()
                .Property(e => e.ddd_tel_sol2)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os>()
                .Property(e => e.usuario_sol)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_analista>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_chamado>()
                .Property(e => e.ds_chamado)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_chamado>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_chamado>()
                .Property(e => e.ds_solucao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_chamado>()
                .Property(e => e.tempo)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_chamado>()
                .Property(e => e.dt_chamado)
                .HasPrecision(0);

            modelBuilder.Entity<cao_os_chamado>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_chamado>()
                .Property(e => e.co_analista)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_chamado>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_daily_report>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_daily_report>()
                .Property(e => e.data)
                .HasPrecision(0);

            modelBuilder.Entity<cao_os_email>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_email>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_email>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_email>()
                .Property(e => e.ddd)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_email>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_email>()
                .Property(e => e.cargo)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_fase>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_fase>()
                .Property(e => e.descricao_ingl)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_item_menu>()
                .Property(e => e.ds_item)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_obs>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_obs>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_obs>()
                .Property(e => e.dt_obs)
                .HasPrecision(0);

            modelBuilder.Entity<cao_os_obs_chamado>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_obs_chamado>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_obs_chamado>()
                .Property(e => e.dt_obs)
                .HasPrecision(0);

            modelBuilder.Entity<cao_os_obs_chamado>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_obs_chamado>()
                .Property(e => e.arquivo_obs)
                .IsUnicode(false);

            modelBuilder.Entity<cao_os_status>()
                .Property(e => e.ds_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cao_pagamento>()
                .Property(e => e.co_pagamento)
                .HasPrecision(20, 0);

            modelBuilder.Entity<cao_pagamento>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_pagamento>()
                .Property(e => e.tp_pagamento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cao_participacao_funcionario>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_pontos_conhecimento>()
                .Property(e => e.co_coordenador)
                .IsUnicode(false);

            modelBuilder.Entity<cao_ramo>()
                .Property(e => e.ds_ramo)
                .IsUnicode(false);

            modelBuilder.Entity<cao_salario>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_servico>()
                .Property(e => e.ds_servico)
                .IsUnicode(false);

            modelBuilder.Entity<cao_sistema>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_sistema>()
                .Property(e => e.no_sistema)
                .IsUnicode(false);

            modelBuilder.Entity<cao_sistema>()
                .Property(e => e.ds_sistema_resumo)
                .IsUnicode(false);

            modelBuilder.Entity<cao_sistema>()
                .Property(e => e.ds_caracteristica)
                .IsUnicode(false);

            modelBuilder.Entity<cao_sistema>()
                .Property(e => e.ds_requisito)
                .IsUnicode(false);

            modelBuilder.Entity<cao_sistema>()
                .Property(e => e.no_diretoria_solic)
                .IsUnicode(false);

            modelBuilder.Entity<cao_sistema>()
                .Property(e => e.ddd_telefone_solic)
                .IsUnicode(false);

            modelBuilder.Entity<cao_sistema>()
                .Property(e => e.nu_telefone_solic)
                .IsUnicode(false);

            modelBuilder.Entity<cao_sistema>()
                .Property(e => e.no_usuario_solic)
                .IsUnicode(false);

            modelBuilder.Entity<cao_sistema_obs>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_sistema_obs>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_sistema_obs>()
                .Property(e => e.dt_obs)
                .HasPrecision(0);

            modelBuilder.Entity<cao_status_agendamento>()
                .Property(e => e.ds_status_agendamento)
                .IsUnicode(false);

            modelBuilder.Entity<cao_status_cliente>()
                .Property(e => e.ds_status)
                .IsUnicode(false);

            modelBuilder.Entity<cao_status_cliente_complemento>()
                .Property(e => e.ds_status)
                .IsUnicode(false);

            modelBuilder.Entity<cao_status_os>()
                .Property(e => e.ds_status)
                .IsUnicode(false);

            modelBuilder.Entity<cao_temp_import>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_tipo_conhecimento_usuario>()
                .Property(e => e.ds_conhecimento)
                .IsUnicode(false);

            modelBuilder.Entity<cao_tipo_custo>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_tipo_idioma_usuario>()
                .Property(e => e.ds_idioma)
                .IsUnicode(false);

            modelBuilder.Entity<cao_tipo_ombudsman>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cao_tipo_ombudsman>()
                .HasMany(e => e.cao_ombudsman)
                .WithRequired(e => e.cao_tipo_ombudsman)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cao_tipo_sistema_usuario>()
                .Property(e => e.ds_sistema)
                .IsUnicode(false);

            modelBuilder.Entity<cao_uf>()
                .Property(e => e.ds_uf)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cao_usuario>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_usuario>()
                .Property(e => e.nu_matricula)
                .HasPrecision(20, 0);

            modelBuilder.Entity<cao_usuario>()
                .Property(e => e.dt_inclusao)
                .HasPrecision(0);

            modelBuilder.Entity<cao_usuario>()
                .Property(e => e.dt_alteracao)
                .HasPrecision(0);

            modelBuilder.Entity<cao_usuario>()
                .HasMany(e => e.cao_conhecimentos)
                .WithRequired(e => e.cao_usuario)
                .HasForeignKey(e => e.usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cao_usuario>()
                .HasMany(e => e.cao_permissao)
                .WithRequired(e => e.cao_usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cao_usuario>()
                .HasMany(e => e.cao_salario_pag)
                .WithRequired(e => e.cao_usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cao_usuario_dt_disp>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_valor_descanso>()
                .Property(e => e.segundos)
                .IsUnicode(false);

            modelBuilder.Entity<cao_valor_descanso>()
                .Property(e => e.mes_referencia)
                .IsUnicode(false);

            modelBuilder.Entity<permissao_sistema>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<permissao_sistema>()
                .Property(e => e.co_tipo_usuario)
                .HasPrecision(20, 0);

            modelBuilder.Entity<permissao_sistema>()
                .Property(e => e.co_sistema)
                .HasPrecision(20, 0);

            modelBuilder.Entity<permissao_sistema>()
                .Property(e => e.in_ativo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<permissao_sistema>()
                .Property(e => e.dt_atualizacao)
                .HasPrecision(0);

            modelBuilder.Entity<tipo_usuario>()
                .Property(e => e.co_tipo_usuario)
                .HasPrecision(20, 0);

            modelBuilder.Entity<tipo_usuario>()
                .Property(e => e.co_sistema)
                .HasPrecision(20, 0);

            modelBuilder.Entity<cao_horario_almoco>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_horario_almoco>()
                .Property(e => e.almoco_saida_hora)
                .IsUnicode(false);

            modelBuilder.Entity<cao_horario_almoco>()
                .Property(e => e.almoco_volta_hora)
                .IsUnicode(false);

            modelBuilder.Entity<cao_permissao>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_permissao>()
                .Property(e => e.permissao_intervalo)
                .IsUnicode(false);

            modelBuilder.Entity<cao_permissao>()
                .Property(e => e.permissao_hora_extra)
                .IsUnicode(false);

            modelBuilder.Entity<cao_salario_pag>()
                .Property(e => e.co_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cao_salario_pag>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<cao_salario_pag>()
                .Property(e => e.observacao)
                .IsUnicode(false);
        }
    }
}
