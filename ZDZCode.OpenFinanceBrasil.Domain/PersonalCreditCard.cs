using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalCreditCard
    {
        /// <summary>
        /// Denominação/Identificação do nome da conta (cartão de crédito)
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Informações de identificação do cartão de crédito
        /// </summary>
        [Required]
        public PersonalCreditCardIdentification Identification { get; set; }

        /// <summary>
        /// Informações sobre programas de recompensa presentes no cartão de crédito
        /// </summary>
        [Required]
        public PersonalCreditCardRewardProgram RewardsProgram { get; set; }

        /// <summary>
        /// Objeto que reúne informações de tarifas de serviços
        /// </summary>
        [Required]
        public PersonalCreditCardFee Fees { get; set; }

        /// <summary>
        /// Informações sobre taxas de juros
        /// </summary>
        [Required]
        public CreditCardInterest interest { get; set; }

        /// <summary>
        /// Informações sobre termos e condições para aquisição e cancelamento
        /// </summary>
        [Required]
        public CreditCardTermsConditions termsConditions { get; set; }
    }
}
