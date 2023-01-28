using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalCreditCardIdentificationProduct
    {
        /// <summary>
        /// ategoria atribuída a um cartão de pagamento, sob uma certa denominação, que lhe agrega um conjunto de vantagens, diferenciando-o de acordo com o perfil do portador. Essa categoria é definida pelo BACEN e está contida no documento de nome 'Elaboração e Remessa de Informações Relativas aos Cartões de Pagamento Emissores'
        /// </summary>
        [Required]
        public EnumPersonalCreditCardProductType type { get; set; }

        /// <summary>
        /// Texto livre para especificar
        /// </summary>
        [Required]
        public string additionalInfo { get; set; }

    }
}
