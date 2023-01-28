using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Listagem de regime financeiro para cada combinação de modalidade/cobertura do produto indicando
    /// </summary>
    public enum InsurancePensionEnumFinancialRegime
    {
        /// <summary>
        /// Repartição simples.
        /// </summary>
        [Description("Repartição simples")]
        REPARTICAO_SIMPLES = 1,

        /// <summary>
        /// Repartição Capitais Cobertura.
        /// </summary>
        [Description("Repartição Capitais Cobertura")]
        REPARTICAO_CAPITAIS = 2,

        /// <summary>
        /// Capitalização.
        /// </summary>
        [Description("Capitalização")]
        CAPITALIZACAO = 3,
    }
}
