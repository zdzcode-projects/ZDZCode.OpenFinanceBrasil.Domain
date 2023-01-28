using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// É o conjunto dos riscos cobertos elencados na apólice. (RESOLUÇÃO CNSP Nº 341/2016). Listagem de coberturas incluídas no produto que deve observar a relação discriminada de coberturas, conforme Tabela Tipo de Cobertura
    /// </summary>
    public enum EnumCoverageType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ADIANTAMENTO_DOENCA_ESTAGIO_TERMINAL = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        AUXILIO_CESTA_BASICA = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        AUXILIO_FINANCEIRO_IMEDIATO = 3,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CANCELAMENTO_VIAGEM = 4,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CIRURGIA = 5,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        COBERTURA_HERNIA = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        COBERTURA_LER_DORT = 7,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CUIDADOS_PROLONGADOS_ACIDENTE = 8,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESEMPREGO_PERDA_RENDA = 9,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_EXTRA_INVALIDEZ_PERMANENTE_TOTAL_PARCIAL_ACIDENTE_DEI = 10,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_EXTRA_MORTE_DEM = 11,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_MEDICAS_HOSPITALARES_ODONTOLOGICAS = 12,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_MEDICAS_HOSPITALARES_ODONTOLOGICAS_BRASIL = 13,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_MEDICAS_HOSPITALARES_ODONTOLOGICAS_EXTERIOR = 14,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DIARIA_INCAPACIDADE_TOTAL_TEMPORARIA = 15,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DIARIA_INTERNACAO_HOSPITALAR = 16,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        INTERNACAO_HOSPITALAR = 17,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DIARIAS_INCAPACIDADE_PECUNIARIA_DIP = 18,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DOENCA_CONGENITA_FILHOS_DCF = 19,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FRATURA_OSSEA = 20,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DOENCAS_TROPICAIS = 21,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        INCAPACIDADE_TOTAL_OU_TEMPORARIA = 22,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        INVALIDEZ_PERMANENTE_TOTAL_PARCIAL = 23,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        INVALIDEZ_TOTAL_ACIDENTE = 24,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        INVALIDEZ_PARCIAL_ACIDENTE = 25,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        INVALIDEZ_FUNCIONAL_PERMANENTE_DOENCA = 26,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        INVALIDEZ_LABORATIVA_DOENCA = 27,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MORTE = 28,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MORTE_ACIDENTAL = 29,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MORTE_CONJUGE = 30,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MORTE_FILHOS = 31,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MORTE_ADIATAMENTO_DOENCA_ESTAGIO_TERMINAL = 32,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PAGAMENTO_ANTECIPADO_ESPECIAL_DOENCA_PROFISSIONAL_PAED = 33,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PERDA_AUTONOMIA_PESSOAL = 34,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PERDA_INVOLUNTARIA_EMPREGO = 35,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        QUEIMADURA_GRAVE = 36,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        REGRESSO_ANTECIPADO_SANITARIO = 37,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        RENDA_INCAPACIDADE_TEMPORARIA = 38,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        RESCISAO_CONTRATUAL_CASO_MORTE_RCM = 39,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        RESCISAO_TRABALHISTA = 40,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SERVICO_AUXILIO_FUNERAL = 41,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SOBREVIVENCIA = 42,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TRANSPLANTE_ORGAOS = 43,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TRASLADO = 44,


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TRANSLADO_CORPO = 45,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        VERBA_RESCISORIA = 46,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS = 47,
    }
}
