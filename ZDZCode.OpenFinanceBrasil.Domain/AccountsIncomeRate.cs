using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AccountsIncomeRate
    {
        // Zdz conferi se esta certo, joão              
        public class Root
        {
            /// <summary>
            /// escrição da Remuneração especificamente para Conta de Poupança
            /// </summary>
            [Display(Name = "escrição da Remuneração especificamente para Conta de Poupança ")]
            [MaxLength(3)]
            [StringLength(500)]
            [MinLength(500)]
            public string? savingAccount { get; set; }

            /// <summary>
            /// Campo Livre. Deve explicitar o Percentual em favor do titular da conta de pagamento pré-paga. P.ex. '40% de rendimento a.m.'
            /// </summary>
            [Display(Name = "Campo Livre ")]
            [MaxLength(3)]
            [StringLength(500)]
            [MinLength(500)]
            public string? prepaidPaymentAccount { get; set; }
        }

    }
}
