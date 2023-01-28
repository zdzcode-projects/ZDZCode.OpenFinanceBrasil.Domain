using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Especifica o tipo de ativo negociado
    /// </summary>
    public enum EnumInvestmentsVariableIncomeInvestmentType
    {
        /// <summary>
        /// Ações.
        /// </summary>
        [Description("Telefone fixo")]
        ACOES = 1,

        /// <summary>
        /// Fundo de índices
        /// </summary>
        [Description("Fundo de índices")]
        FUNDO_INDICES = 2,
    }
}
