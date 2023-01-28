using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CustomerPhone
    {
        /// <summary>
        /// Indica se o telefone informado é o principal
        /// </summary>
        [Required]
        public bool isMain { get; set; }

        /// <summary>
        /// Identificação do Tipo de telefone do cliente.
        /// </summary>
        [Required]
        public EnumCustomerPhoneType Type { get; set; }

        /// <summary>
        /// Informação complementar relativa ao tipo de telefone selecionado. [Restrição] De preenchimento obrigatório quando selecionado o tipo 'OUTRO'.
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Número de DDI (Discagem Direta Internacional) para telefone de acesso ao Cliente - se houver
        /// </summary>
        [Required]
        public string CountryCallingCode { get; set; }

        /// <summary>
        /// Número de DDD (Discagem Direta à Distância) do telefone do cliente - se houver
        /// </summary>
        [Required]
        public EnumAreaCode AreaCode { get; set; }

        /// <summary>
        /// Número de telefone do cliente
        /// </summary>
        [Required]
        public string Number { get; set; }

        /// <summary>
        /// Número do ramal. De preenchimento obrigatório se fizer parte da identificação do número do telefone informado
        /// </summary>
        [Required]
        public string PhoneExtension { get; set; }
    }
}
