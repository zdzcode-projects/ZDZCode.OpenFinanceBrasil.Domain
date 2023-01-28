using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalAccountCompany
    {
        /// <summary>
        /// Nome da Instituição, pertencente à marca, responsável pelas modalidades de Contas para Pessoa Natural. p.ex.'Empresa da Organização A'
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// O responsável pela comercialização das modalidades de Contas.
        /// </summary>
        [Required]
        public string CnpjNumber { get; set; }

        /// <summary>
        /// URL do link que conterá a lista complementar com os nomes e CNPJs agrupados sob o mesmo cnpjNumber. Os contidos nessa lista possuem as mesmas características para produtos e serviços. Restrição: Será obrigatorimente preenchido se houver lista complementar com os nomes e CNPJs a ser disponibilizada
        /// </summary>
        public string UrlComplementaryList { get; set; }

        /// <summary>
        /// Lista de tipos de conta
        /// </summary>
        [Required]
        public PersonalAccount PersonalAccounts { get; set; }


    }
}
