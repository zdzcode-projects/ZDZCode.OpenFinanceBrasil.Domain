using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipo de saldo informado
    /// </summary>
    public enum EnumOverdraftLimitType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        VALOR_CONTRATADO_LIMITE = 1,

        /// <summary>
        /// Valor utilizado do limite do cheque especial
        /// </summary>
        [Description("")]
        VALOR_UTILIZADO_LIMITE = 2,

        /// <summary>
        /// Saldo a descoberto em conta de depósito à vista (relativo ao excesso do limite de cheque especial ou ao adiantamento a depositante)
        /// </summary>
        [Description("")]
        SALDO_DESCOBERTO = 3,
    }
}
