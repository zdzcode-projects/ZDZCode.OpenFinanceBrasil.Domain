using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalFinancing
    {
        /// <summary>
        /// Modalidades de financiamentos ofertados, conforme Circular 4015-Banco Central do Brasil. Segundo cartilha do Banco Central do Brasil: Financiamento é um contrato entre o cliente e uma instituição financeira, mas com, destinação específica como para a aquisição de veículo ou de bem imóvel, que funcionam como garantia para o crédito concedido.
        /// </summary>
        [Required]
        public EnumPersonalFinancingType type { get; set; }

        /// <summary>
        /// Objeto que reúne informações de tarifas de serviços
        /// </summary>
        [Required]
        public PersonalFinancingFee fees { get; set; }

        /// <summary>
        /// Lista que traz o conjunto de informações necessárias para demonstrar a distribuição de frequências das taxas de juros remuneratórios da Modalidade de crédito
        /// </summary>
        [Required]
        public PersonalFinancingInterestRate interestRates { get; set; }

        /// <summary>
        /// Relação de garantias exigidas.
        /// </summary>
        [Required]
        public EnumPersonalFinancingRequiredWarranty requiredWarranties { get; set; }

        /// <summary>
        /// Campo aberto para informar as condições contratuais relativas ao produto ou serviço informado. Pode ser informada a URL (URIString) referente ao endereço onde constam as condições informadas.
        /// </summary>
        [Required]
        public string termsConditions { get; set; }

    }
}
