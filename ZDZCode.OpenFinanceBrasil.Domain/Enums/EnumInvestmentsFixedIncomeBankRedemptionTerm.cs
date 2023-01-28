using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Capacidade de conversão do título em dinheiro (resgate ou recompra).
    /// </summary>
    public enum EnumInvestmentsFixedIncomeBankRedemptionTerm
    {
        /// <summary>
        /// Diária
        /// </summary>
        [Description("Diária")]
        DIARIA = 1,

        /// <summary>
        /// Na data de vencimento
        /// </summary>
        [Description("Na data de vencimento")]
        DATA_VENCIMENTO = 2,

        /// <summary>
        /// Diária após prazo de carência
        /// </summary>
        [Description("Diária após prazo de carência")]
        DIARIA_PRAZO_CARENCIA = 3,
    }
}
