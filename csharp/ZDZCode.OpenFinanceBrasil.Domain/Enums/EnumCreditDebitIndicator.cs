using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Indicador do tipo de lançamento: Débito (no extrato) Em um extrato bancário, os débitos, marcados com a letra “D” ao lado do valor registrado, informam as saídas de dinheiro na conta-corrente. Crédito (no extrato) Em um extrato bancário, os créditos, marcados com a letra “C” ao lado do valor registrado, informam as entradas de dinheiro na conta-corrente.
    /// </summary>
    public enum EnumCreditDebitIndicator
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CREDITO = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DEBITO = 2,
    }
}
