using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PhoneChannels
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public PhoneChannelsIdentification identification { get; set; }

        /// <summary>
        /// Traz a relação de serviços disponbilizados pelo Canal de Atendimento
        /// </summary>
        [Required]
        public PhoneChannelsServices services { get; set; }
    }
}
