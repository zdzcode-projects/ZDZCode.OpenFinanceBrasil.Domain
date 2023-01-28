using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CreditCardInterest
    {
        /// <summary>
        /// Lista da representação que traz o conjunto de informações necessárias para demonstrar a distribuição de frequências das taxas de juros remuneratórios para crédito rotativo
        /// </summary>
        [Required]
        public List<CreditCardRate> Rates { get; set; }

        /// <summary>
        /// Percentual que corresponde a taxa aplicada para pagamento parcelado do saldo devedor quando não realizado pagamento integral da fatura
        /// </summary>
        [Required]
        public List<CreditCardInstalmentRate> InstalmentRates { get; set; }

        /// <summary>
        /// Lista de outras operações de crédito
        /// </summary>
        [Required]
        public List<CreditCardInterestRate> OtherCredits { get; set; }
    }
}
