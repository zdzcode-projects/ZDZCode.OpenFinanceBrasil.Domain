using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PhoneChannelsServices
    {
        /// <summary>
        /// Nome dos Serviços efetivamente prestados pelo Canal de Atendimento.	
        /// </summary>
        [Required]
        public EnumPhoneChannelsServicesName name { get; set; }

        /// <summary>
        /// Código dos Serviços efetivamente prestados pelo Canal de Atendimento.	
        /// </summary>
        [Required]
        public EnumPhoneChannelsServicesCode code { get; set; }

        /// <summary>
        /// Texto livre para complementar informação relativa ao Serviço disponível, quando for selecionada a opção 'OUTROS_PRODUTOS_SERVICOS'
        /// </summary>
        public string additionalInfo { get; set; }


    }
}
