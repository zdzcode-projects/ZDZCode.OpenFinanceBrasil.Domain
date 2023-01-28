using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalCreditCardIdentification
    {
        /// <summary>
        /// Categoria atribuída a um cartão de pagamento, sob uma certa denominação, que lhe agrega um conjunto de vantagens, diferenciando-o de acordo com o perfil do portador
        /// </summary>
        [Required]
        public PersonalCreditCardIdentificationProduct product { get; set; }

        /// <summary>
        /// Categoria de Bandeiras de Cartões de Crédito
        /// </summary>
        [Required]
        public PersonalCreditCardIdentificationCreditCard creditCard { get; set; }
    }
}
