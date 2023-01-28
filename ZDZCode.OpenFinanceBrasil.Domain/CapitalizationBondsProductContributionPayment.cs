using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CapitalizationBondsProductContributionPayment
    {
        /// <summary>
        /// Meio de Pagamento utilizado para pagamento da contribuição. A considerar os domínios abaixo:
        /// 1. Cartão de Crédito
        /// 2. Cartão de Débito
        /// 3. Débito em conta corrente
        /// 4. Débito em conta poupança
        /// 5. Boleto bancário
        /// 6. PIX
        /// 7. Consignação em Folha de Pagamento
        /// 8. Pontos de Programas de Benefício
        /// 9. Outros
        /// </summary>
        [Required]
        public CapitalizationBondsProductPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Restrição: Campo obrigatório para complementar a informação quando selecionada a opção 'OUTROS'
        /// </summary>
        public string PaymentMethodAdditionalInfo { get; set; }

        /// <summary>
        /// Índice utilizado na atualização dos pagamentos mensais (para títulos com mais de 12 meses de vigência) (não aplicável a pagamento único).
        /// </summary>
        [Required]
        public CapitalizationBondsProductUpdateIndex UpdateIndex { get; set; }

        /// <summary>
        /// Restrição: Campo obrigatório para complementar a informação quando selecionada a opção 'OUTROS'
        /// </summary>
        public string UpdateIndexAdditionalInfo { get; set; }
    }
}
