using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipos de contas usadas para pagamento via Pix. Modalidades tradicionais previstas pela Resolução 4.753, não contemplando contas vinculadas, conta de domiciliados no exterior, contas em moedas estrangeiras e conta correspondente moeda eletrônica. Segue descrição de cada valor do ENUM para o escopo do Pix.
    /// CACC - Current - Conta Corrente.
    /// SLRY - Salary - Conta-Salário.
    /// SVGS - Savings - Conta de Poupança.
    /// TRAN - TransactingAccount - Conta de Pagamento pré-paga.
    /// </summary>
    public enum EnumAccountPaymentsType //enum com prioridades, confirmar com o Zids.
    {
        /// <summary>
        /// CACC - Current - Conta Corrente.
        /// </summary>
        [Description("CACC - Current - Conta Corrente.")]
        CACC = 1,

        /// <summary>
        /// SLRY - Salary - Conta-Salário.
        /// </summary>
        [Description("SLRY - Salary - Conta-Salário.")]
        SLRY = 2,

        /// <summary>
        /// SVGS - Savings - Conta de Poupança.
        /// </summary>
        [Description("SVGS - Savings - Conta de Poupança.")]
        SVGS = 3,

        /// <summary>
        /// TRAN - TransactingAccount - Conta de Pagamento pré-paga.
        /// </summary>
        [Description("TRAN - TransactingAccount - Conta de Pagamento pré-paga.")]
        TRAN = 4,
    }
}
