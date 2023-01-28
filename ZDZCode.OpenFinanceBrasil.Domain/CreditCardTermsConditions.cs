using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CreditCardTermsConditions
    {
        /// <summary>
        /// Percentual para pagamento mínimo sobre o saldo devedor da fatura
        /// </summary>
        [Required]
        public string MinimumFeeRate { get; set; }

        /// <summary>
        /// Campo aberto para detalhamento de taxas de juros. Restrição: Se o campo 'code' vier selecionado com 'OUTROS' é obrigatório o preenchimento do additonalInfo
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Informação sobre as condições e critérios de elegibilidade do emissor do cartão. Pode ser informada a URL referente ao endereço onde constam as condições informadas.
        /// </summary>
        [Required]
        public string ElegibilityCriteriaInfo { get; set; }

        /// <summary>
        /// Descrição dos procedimentos para encerramento da conta de pagamento pós paga. Pode ser informada a URL referente ao endereço onde constam as condições informadas.
        /// </summary>
        [Required]
        public string ClosingProcessInfo { get; set; }
    }
}
