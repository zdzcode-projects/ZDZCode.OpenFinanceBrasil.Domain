using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BusinessAccountsCompany
    {
        /// <summary>
        /// Nome da Instituição, pertencente à marca, responsável pela comercialização dos tipos de contas de pessoas jurídicas consultadas.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// O responsável pela comercialização das modalidades de Contas para Pessoas Jurídicas consultadas.
        /// </summary>
        [Required]
        public string CnpjNumber { get; set; }

        /// <summary>
        /// URL do link que conterá a lista complementar com os nomes e CNPJs agrupados sob o mesmo cnpjNumber. Os contidos nessa lista possuem as mesmas características para produtos e serviços.
        /// </summary>
        [Required]
        public string UrlComplementaryList { get; set; }

        /// <summary>
        /// lista de tipos de conta.
        /// </summary>
        [Required]
        public List<BusinessAccount> BusinessAccounts { get; set; }
    }
}
