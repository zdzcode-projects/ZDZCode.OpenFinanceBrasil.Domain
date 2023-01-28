using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CreditCardsAccountsIdentificationData
    {
        /// <summary>
        /// Denominação/Identificação do nome da conta de pagamento pós-paga (cartão). Conforme CIRCULAR Nº 3.680,BCB, 2013: 'conta de pagamento pós-paga: destinada à execução de transações de pagamento que independem do aporte prévio de recursos'.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Categoria atribuída a um cartão de pagamento, sob uma certa denominação, que lhe agrega um conjunto de vantagens, diferenciando-o de acordo com o perfil do portador.
        /// </summary>
        [Required]
        public EnumCreditCardAccountsProductType ProductType { get; set; }

        /// <summary>
        /// Informações complementares se tipo de Cartão 'OUTROS'
        /// </summary>
        public string ProductAdditionalInfo { get; set; }

        /// <summary>
        /// Categoria de Bandeiras de Cartões de Crédito (Instituidor do arranjo de pagamento). Bandeira é a detentora de todos os direitos e deveres da utilização da marca estampada no cartão, inclusive as bandeiras pertencentes aos emissores.
        /// </summary>
        [Required]
        public EnumCreditCardAccountNetwork CreditCardNetwork { get; set; }

        /// <summary>
        /// Texto livre para especificar categoria de bandeira marcada como 'OUTRAS'.
        /// </summary>
        public string NetworkAdditionalInfo { get; set; }

        /// <summary>
        /// [Conjunto de informações relativas aos Meios de Pagamento da Conta de pagamento pós-paga]
        /// </summary>
        [Required]
        public List<CreditCardsAccountPaymentMethod> PaymentMethod { get; set; }
    }
}
