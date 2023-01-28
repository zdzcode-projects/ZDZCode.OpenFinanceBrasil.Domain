using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalUnarrangedAccountOverdraft
    {
        /// <summary>
        /// Objeto que reúne informações de tarifas de serviços
        /// </summary>
        [Required]
        public PersonalUnarrangedAccountOverdraftFee fees { get; set; }

        /// <summary>
        /// Lista que traz o conjunto de informações necessárias para demonstrar a distribuição de frequências das taxas de juros remuneratórios da Modalidade de crédito
        /// </summary>
        [Required]
        public UnarrangedAccountOverdraftRate interestRates { get; set; }

        /// <summary>
        /// Campo aberto para informar as condições contratuais relativas à Modalidade de Adiantamento a depositante para pessoa natural. Pode ser informada a URL referente ao endereço onde constam as condições informadas. Endereço eletrônico de acesso ao canal.
        /// </summary>
        [Required]
        public string termsConditions { get; set; }

    }
}
