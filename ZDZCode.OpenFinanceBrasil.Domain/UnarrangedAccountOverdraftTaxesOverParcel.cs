using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class UnarrangedAccountOverdraftTaxesOverParcel
    {
        /// <summary>
        /// Tipo de encargo pago fora da parcela
        /// </summary>
        [Required]
        public EnumTaxType TaxType { get; set; }

        /// <summary>
        /// Campo de preenchimento obrigatório se selecionada a opção 'OUTROS' em Tipo de encargo pago fora da parcela
        /// </summary>
        public string TaxAdditionalInfo { get; set; }

        /// <summary>
        /// Traz a data de efetivação do pagamento do encargo pago fora da parcela, conforme especificação RFC-3339
        /// </summary>
        [Required]
        public string TaxpaidDate { get; set; }

        /// <summary>
        /// Traz o valor do pagamento do encargo pago fora da parcela. Expresso em valor monetário com 2 casas decimais
        /// </summary>
        [Required]
        public int TaxAmount { get; set; }
    }
}
