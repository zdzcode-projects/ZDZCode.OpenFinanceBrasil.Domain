using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalInvoiceFinancings
    {
        /// <summary>
        /// Modalidades de direitos creditórios descontados ofertados, conforme Circular 4015-Bacen. Direito creditório descontado é a antecipação de créditos relativos p.ex.: desconto de duplicatas, desconto de cheques, antecipação de fatura de cartão de crédito
        /// </summary>
        [Required]
        public EnumPersonalInvoiceFinancingsType type { get; set; }

        /// <summary>
        /// Objeto que reúne informações de tarifas de serviços
        /// </summary>
        [Required]
        public PersonalInvoiceFinancingsFees fees { get; set; }

        /// <summary>
        /// Taxas de juros remuneratórias
        /// </summary>
        [Required]
        public PersonalInvoiceFinancingsInterestRate interestRate { get; set; }

        /// <summary>
        /// Lista das garantias exigidas
        /// </summary>
        [Required]
        public EnumPersonalInvoiceFinancingsRequiredWarranties requiredWarranties { get; set; }

        /// <summary>
        /// Campo aberto para informar as condições contratuais relativas à Modalidade de Financiamentos para pessoa natural informada. Pode ser informada a URL referente ao endereço onde constam as condições informadas. Endereço eletrônico de acesso ao canal.
        /// </summary>
        [Required]
        public string termsConditions { get; set; }
    }
}
