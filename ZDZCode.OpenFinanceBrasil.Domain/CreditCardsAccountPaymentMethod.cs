using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Conjunto de informações relativas aos Meios de Pagamento da Conta de pagamento pós-paga.
    /// </summary>
    public class CreditCardsAccountPaymentMethod
    {
        /// <summary>
        /// Número de identificação do cartão: corresponde aos 4 últimos dígitos do cartão para pessoa natural, ou então, preencher com um identificador para pessoa jurídica, com as características definidas para os IDs no Open Banking.
        /// </summary>
        [Required]
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// Indica se o Cartão de crédito associado à conta pagamento pós-paga é múltiplo ou não. Cartões denominados múltiplos possuem tanto a função crédito quanto a função débito, devendo o proprietário do cartão, no momento de sua utilização, informar se o pagamento é na função crédito (que leva a um pagamento futuro, por meio de uma fatura do cartão de crédito) ou na função débito.
        /// </summary>
        [Required]
        public bool IsMultipleCreditCard { get; set; }
    }
}
