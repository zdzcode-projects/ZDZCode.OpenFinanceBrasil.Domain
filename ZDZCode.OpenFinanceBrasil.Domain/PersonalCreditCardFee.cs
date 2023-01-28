using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalCreditCardFee
    {
        /// <summary>
        /// Lista das Tarifas cobradas sobre Serviço relacionadas a Modalidade de Pagamento Pós-Pagas
        /// </summary>
        [Required]
        public PersonalCreditCardService Services { get; set; }
    }
}
