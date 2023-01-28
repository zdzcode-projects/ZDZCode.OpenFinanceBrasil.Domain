using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PhoneChannelsCompanies
    {
        /// <summary>
        /// Nome da Instituição, pertencente à organização, responsável pelo Canal Telefônico. Ex. 'Empresa da Organização A'.
        /// </summary>
        [Required]
        public string name { get; set; }

        /// <summary>
        /// CNPJ da instituição responsável pelo canal de atendimento telefônico - o CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica.
        /// </summary>
        [Required]
        public string cnpjNumber { get; set; }

        /// <summary>
        /// URL do link que conterá a lista complementar com os nomes e CNPJs agrupados sob o mesmo cnpjNumber.
        /// </summary>
        public string urlComplementaryList { get; set; }

        /// <summary>
        /// Lista de canais de atendimento telefônico.
        /// </summary>
        [Required]
        public PhoneChannels phoneChannels { get; set; }
    }
}
