using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalInvoiceFinancingsCompanies
    {
        /// <summary>
        /// CNPJ da instituição responsável	
        /// </summary>
        [Required]
        public string cnpjNumber { get; set; }

        /// <summary>
        /// Nome da Instituição, pertencente à marca, responsável pela modalidade de Direitos Creditórios Descontados para Pessoa Natural. p.ex.'Empresa da Organização A'
        /// </summary>
        [Required]
        public string name { get; set; }

        /// <summary>
        /// URL do link que conterá a lista complementar com os nomes e CNPJs agrupados sob o mesmo cnpjNumber. Os contidos nessa lista possuem as mesmas características para produtos e serviços.
        /// </summary>
        public string urlComplementaryList { get; set; }

        /// <summary>
        /// Lista de Modalidades de Direitos Creditórios Descontados ofertados
        /// </summary>
        [Required]
        public PersonalInvoiceFinancings personalInvoiceFinancings { get; set; }
    }
}
