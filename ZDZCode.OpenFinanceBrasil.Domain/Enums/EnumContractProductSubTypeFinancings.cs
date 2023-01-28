using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Sub tipo da modalidades de crédito contratadas, conforme circular 4.015 e descrição do DOC3040 do SCR).
    /// </summary>
    public enum EnumContractProductSubTypeFinancings
    {
        /// <summary>
        /// Aquisição de bens veículos automotores.
        /// </summary>
        [Description("Aquisição de bens veículos automotores")]
        AQUISICAO_BENS_VEICULOS_AUTOMOTORES = 1,

        /// <summary>
        /// Aquisição de bens de outros bens.
        /// </summary>
        [Description("Aquisição de bens de outros bens")]
        AQUISICAO_BENS_OUTROS_BENS = 2,

        /// <summary>
        /// Microcrédito, Custeio.
        /// </summary>
        [Description("Microcrédito, Custeio")]
        MICROCREDITO = 3,

        /// <summary>
        /// Custeio.
        /// </summary>
        [Description("Custeio")]
        CUSTEIO = 4,

        /// <summary>
        /// Investimento.
        /// </summary>
        [Description("Investimento")]
        INVESTIMENTO = 5,

        /// <summary>
        /// Industrialização.
        /// </summary>
        [Description("Industrialização")]
        INDUSTRIALIZACAO = 6,

        /// <summary>
        /// Comercialização.
        /// </summary>
        [Description("Comercialização")]
        COMERCIALIZACAO = 7,

        /// <summary>
        /// Financiamento habitacional SFH.
        /// </summary>
        [Description("Financiamento habitacional SFH")]
        FINANCIAMENTO_HABITACIONAL_SFH = 8,

        /// <summary>
        /// Financiamento habitacional exceto SFH.
        /// </summary>
        [Description("Financiamento habitacional exceto SFH")]
        FINANCIAMENTO_HABITACIONAL_EXCETO_SFH = 9,
    }
}
