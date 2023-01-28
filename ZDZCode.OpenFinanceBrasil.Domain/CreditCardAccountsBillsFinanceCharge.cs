using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CreditCardAccountsBillsFinanceCharge
    {
        /// <summary>
        /// Traz a denominação dos Encargos que
        /// incidem na fatura da conta de pagamento pós-paga. (Vide Enum)
        /// - Juros remuneratórios por atraso no pagamento da fatura
        /// - Multa por atraso no pagamento da fatura
        /// - Juros de mora por atraso no pagamento da fatura
        /// - IOF
        /// - Sem Encargo
        /// - Outros
        /// </summary>
        [Required]
        public EnumCreditCardAccountsFinanceChargeType Type { get; set; }

        /// <summary>
        /// Campo livre, de preenchimento obrigatório se selecionado tipo de encargo 'OUTROS'.
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Valor cobrado pelo encargo. Expresso em valor monetário com 4 casas decimais.
        /// </summary>
        [Required]
        public double Amount { get; set; }

        /// <summary>
        /// Moeda referente ao valor cobrado pelo encargo, segundo modelo ISO-4217. p.ex. 'BRL' Todos os saldos informados estão representados com a moeda vigente do Brasil.
        /// </summary>
        [Required]
        public string Currency { get; set; }
    }
}
