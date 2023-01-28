using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalLoan
    {
        /// <summary>
        /// Modalidades de empréstimos ofertados para pessoas Físicas, conforme Circular 4015-Bacen
        /// </summary>
        [Required]
        public EnumPersonalLoanType type { get; set; }

        /// <summary>
        /// Objeto que reúne informações de tarifas de serviços
        /// </summary>
        [Required]
        public LoanFees fees { get; set; }

        /// <summary>
        /// Lista que traz o conjunto de informações necessárias para demonstrar a distribuição de frequências das taxas de juros remuneratórios da Modalidade de crédito
        /// </summary>
        [Required]
        public LoanInterestRate interestRates { get; set; }

        /// <summary>
        /// Lista das garantias exigidas
        /// </summary>
        [Required]
        public EnumRequiredWarranty requiredWarranties { get; set; }

        /// <summary>
        /// Campo aberto para informar as condições contratuais relativas ao produto ou serviço informado. Pode ser informada a URL (URIString) referente ao endereço onde constam as condições informadas
        /// </summary>
        [Required]
        public string termsConditions { get; set; }
    }
}
