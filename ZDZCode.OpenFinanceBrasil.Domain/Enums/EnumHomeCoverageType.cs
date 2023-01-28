using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// É o conjunto dos riscos cobertos elencados na apólice. (RESOLUÇÃO CNSP Nº 341/2016). Listagem de coberturas incluídas no produto que deve observar a relação discriminada de coberturas, conforme Tabela Tipo de Cobertura
    /// </summary>
    public enum EnumHomeCoverageType
    {
        /// <summary>
        /// Telefone fixo.
        /// </summary>
        [Description("Telefone fixo")]
        IMOVEL_BASICA = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MOIMOVEL_AMPLAVEL = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DANOS_ELETRICOS = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DANOS_AGUA = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ALAGAMENTO = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        RESPONSABILIDADE_CIVIL_FAMILIAR = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        RESPONSABILIDADE_CIVIL_DANOS_MORAIS = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ROUBO_SUBTRACAO_BENS = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ROUBO_SUBTRACAO_BENS_FORA_LOCAL_SEGURADO = 9,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TACOS_GOLFE_HOLE_ONE = 10,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PEQUENAS_REFORMAS_OBRAS = 11,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        GRAVES_TUMULTOS_LOCKOUT = 12,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MICROEMPREENDEDOR = 13,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ESCRITORIO_RESIDENCIA = 14,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DANOS_EQUIPAMENTOS_ELETRONICOS = 15,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        QUEBRA_VIDROS = 16,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        IMPACTO_VEICULOS = 17,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        VENDAVAL = 18,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PERDA_PAGAMENTO_ALUGUEL = 19,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        BICICLETA = 20,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        RESPONSABILIDADE_CIVIL_BICICLETA = 21,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        RC_EMPREGADOR = 22,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESMORONAMENTO = 23,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS = 24,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        JOIAS_OBRAS_ARTE = 25,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TERREMOTO = 26,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        IMPACTO_AERONAVES = 27,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PAISAGISMO = 28,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        INCENDIO = 29,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        QUEDA_RAIO = 30,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        EXPLOSAO = 31,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS = 32,
    }
}
