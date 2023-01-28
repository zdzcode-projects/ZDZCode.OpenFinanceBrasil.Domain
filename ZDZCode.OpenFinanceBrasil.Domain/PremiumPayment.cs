using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PremiumPayment
    {
        /// <summary>
        /// [Meio de pagamento escolhido pelo segurado. A considerar os domínios abaixo:
        /// 1. Cartão de Crédito
        /// 2. Cartão de Débito
        /// 3. Débito em conta corrente
        /// 4. Débito em conta poupança
        /// 5. Boleto bancário
        /// 6. PIX
        /// 7. Consignação em Folha de Pagamento
        /// 8. Pontos de Programa de Benefício
        /// 9. Outros ]
        /// </summary>
        [Required]
        public List<EnumPremiumPaymentMethodType> PaymentMethods { get; set; }

        /// <summary>
        /// Forma de pagamento:
        /// 1. A vista;
        /// 2. Parcelado;
        /// 3. Ambos
        /// </summary>
        [Required]
        public EnumPremiumPaymentType PaymentType { get; set; }

        /// <summary>
        /// Texto livre para complementar informação relativa ao paymentMethods, quando for selecionada a opção 'Outros'. Restrição: Campo de preenchimento obrigatório se "paymentMethods" estiver preenchida a opção "OUTROS"
        /// </summary>
        public string PaymentMethodsAdditionalInfo { get; set; }
    }
}
