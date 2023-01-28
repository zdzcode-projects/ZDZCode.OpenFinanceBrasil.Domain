using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Periodicidade da taxa
    /// </summary>
    public enum EnumContractTaxPeriodicity
    {
        /// <summary>
        /// Ao mês
        /// </summary>
        [Description("Ao mês")]
        AM = 1,

        /// <summary>
        /// Ao ano
        /// </summary>
        [Description("Ao ano")]
        AA = 2,
    }
}
