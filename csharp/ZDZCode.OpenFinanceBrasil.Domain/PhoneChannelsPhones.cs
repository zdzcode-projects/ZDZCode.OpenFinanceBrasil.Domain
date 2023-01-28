using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PhoneChannelsPhones
    {
        /// <summary>
        /// DDI.
        /// </summary>
        [Required]
        public string countryCallingCode { get; set; }

        /// <summary>
        /// DDD.
        /// </summary>
        [Required]
        public string areaCode { get; set; }

        /// <summary>
        /// Telefone para contato com o canal.
        /// </summary>
        [Required]
        public string number { get; set; }

        /// <summary>
        /// Mensagem complementar necessária para o agrupamento da identificação do telefone.
        /// </summary>
        [Required]
        public string additionalInfo { get; set; }
    }
}
