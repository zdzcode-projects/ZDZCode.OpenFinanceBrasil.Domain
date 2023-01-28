using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalCreditCardCompanies
    {
        /// <summary>
        /// 	Nome da instituição financeira
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// CNPJ da instituição financeira
        /// </summary>
        [Required]
        public string cnpjNumber { get; set; }

        /// <summary>
        /// URL do link que conterá a lista complementar com os nomes e CNPJs agrupados sob o mesmo cnpjNumber
        /// </summary>
        public string urlComplementaryList { get; set; }

        /// <summary>
        /// Lista das contas de pagamento pós-paga
        /// </summary>
        [Required]
        public PersonalCreditCard personalCreditCards { get; set; }
    }
}
