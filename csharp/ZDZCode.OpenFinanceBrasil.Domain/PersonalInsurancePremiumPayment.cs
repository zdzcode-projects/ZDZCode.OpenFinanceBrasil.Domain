using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalInsurancePremiumPayment
    {
        /// <summary>
        /// 	[Meio de pagamento escolhido pelo segurado. A considerar os domínios abaixo:
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
        /// [Periodicidade de pagamento do prêmio:
        /// 1. Diária
        /// 2. Mensal
        /// 3. Única
        /// 4. Anual
        /// 5. Trimestral
        /// 6. Semestral
        /// 7. Fracionado
        /// 8. Outra ]
        /// </summary>
        [Required]
        public List<EnumPersonalInsurancePremiumPaymentFrequency> Frequencies { get; set; }

        /// <summary>
        /// Distribuição de frequência relativa aos valores referentes às taxas cobradas, nos termos do Anexo III.
        /// </summary>
        public string ContributionTax { get; set; }
    }
}
