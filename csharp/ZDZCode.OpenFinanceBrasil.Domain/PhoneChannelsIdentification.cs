using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PhoneChannelsIdentification
    {
        /// <summary>
        /// O Tipo de Canal determina o Tipo de Acesso a ele relacionado: telefone da central, telefone do SAC, telefone da ouvidoria.
        /// </summary>
        [Required]
        public EnumPhoneChannelsType type { get; set; }

        /// <summary>
        /// De preenchimento obrigatório quando o tipo de canal de atendimento selecionado for "OUTROS"
        /// </summary>
        public string additionalInfo { get; set; }

        /// <summary>
        ///
        /// </summary>
        public PhoneChannelsPhones phones { get; set; }
    }
}
