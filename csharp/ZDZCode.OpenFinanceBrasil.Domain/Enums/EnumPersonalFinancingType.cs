using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumPersonalFinancingType
    {
        /// <summary>
        /// Aquisição de bens – veículos automotores.
        /// </summary>
        [Description("")]
        FINANCIAMENTO_AQUISICAO_BENS_VEICULOS_AUTOMOTORES = 1,

        /// <summary>
        /// Aquisição de bens – outros bens.
        /// </summary>
        [Description("")]
        FINANCIAMENTO_AQUISICAO_BENS_OUTROS_BENS = 2,

        /// <summary>
        /// Operação de crédito realizada para financiamento de atividades produtivas de pessoas naturais ou jurídicas, organizadas de forma individual ou coletiva, com renda ou receita bruta anual de até R$200.000,00 (duzentos mil reais)
        /// </summary>
        [Description("")]
        FINANCIAMENTO_MICROCREDITO = 3,

        /// <summary>
        /// Financiamentos rurais - custeio.
        /// </summary>
        [Description("")]
        FINANCIAMENTO_RURAL_CUSTEIO = 4,

        /// <summary>
        /// Financiamentos rurais - investimento.   
        /// </summary>
        [Description("")]
        FINANCIAMENTO_RURAL_INVESTIMENTO = 5,

        /// <summary>
        /// Financiamentos rurais - comercialização.
        /// </summary>
        [Description("")]
        FINANCIAMENTO_RURAL_COMERCIALIZACAO = 6,

        /// <summary>
        /// Financiamentos rurais - industrialização.
        /// </summary>
        [Description("")]
        FINANCIAMENTO_RURAL_INDUSTRIALIZACAO = 7,

        /// <summary>
        /// Financimento imobiliário - Sistema Financeiro da Habitação (SFH).
        /// </summary>
        [Description("")]
        FINANCIAMENTO_IMOBILIARIO_SISTEMA_FINANCEIRO_HABITACAO_SFH = 8,

        /// <summary>
        /// Financimento imobiliário - Sistema Financeiro da Imobiliário (SFI).
        /// </summary>
        [Description("")]
        FINANCIAMENTO_IMOBILIARIO_SISTEMA_FINANCEIRO_HABITACAO_SFI = 9,
    }
}
