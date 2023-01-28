using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalCreditCardIdentificationCreditCard
    {
        /// <summary>
        /// Categoria de Bandeiras de Cartões. Bandeira é a detentora de todos os direitos e deveres da utilização da marca estampada no cartão, inclusive as bandeiras pertencentes aos emissores. Essas bandeiras estão definidas em documento do BACEN de nome 'Elaboração e Remessa de Informações Relativas aos Cartões de Pagamento Emissores'
        /// </summary>
        [Required]
        public EnumPersonalCreditCardBrandCode network { get; set; }

        /// <summary>
        /// Texto livre para especificar categoria de bandeira marcada como 'Outras'
        /// </summary>
        [Required]
        public string additionalInfo { get; set; }

    }
}
