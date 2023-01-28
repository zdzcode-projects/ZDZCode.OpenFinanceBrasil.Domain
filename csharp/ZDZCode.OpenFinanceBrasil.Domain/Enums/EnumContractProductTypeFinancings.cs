using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipo da modalidade de crédito contratada, conforme circular 4.015 e descrição do DOC3040 do SCR).
    /// </summary>
    public enum EnumContractProductTypeFinancings
    {
        /// <summary>
        /// Financiamentos.
        /// </summary>
        [Description("Financiamentos")]
        FINANCIAMENTOS = 1,

        /// <summary>
        /// Financiamentos rurais.
        /// </summary>
        [Description("Financiamentos rurais")]
        FINANCIAMENTOS_RURAIS = 2,

        /// <summary>
        /// Financiamentos imobiliários.
        /// </summary>
        [Description("Financiamentos imobiliários")]
        FINANCIAMENTOS_IMOBILIARIOS = 3,
    }
}
