using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumPersonalLoanType
    {
        /// <summary>
        /// Crédito pessoal consignado.
        /// </summary>
        [Description("Crédito pessoal consignado")]
        EMPRESTIMO_CREDITO_PESSOAL_CONSIGNADO = 1,

        /// <summary>
        /// Crédito pessoal sem consignação.
        /// </summary>
        [Description("Crédito pessoal sem consignação")]
        EMPRESTIMO_CREDITO_PESSOAL_SEM_CONSIGNACAO = 2,

        /// <summary>
        /// Home equity.
        /// </summary>
        [Description("Home equity")]
        EMPRESTIMO_HOME_EQUITY = 3,

        /// <summary>
        /// Microcrédito produtivo orientado.
        /// </summary>
        [Description("Microcrédito produtivo orientado")]
        EMPRESTIMO_MICROCREDITO_PRODUTIVO_ORIENTADO = 4,

        /// <summary>
        /// Cheque especial.
        /// </summary>
        [Description("Cheque especial")]
        EMPRESTIMO_CHEQUE_ESPECIAL = 5,

        /// <summary>
        /// Conta garantida.
        /// </summary>
        [Description("Conta garantida")]
        EMPRESTIMO_CONTA_GARANTIDA = 6,
    }
}
