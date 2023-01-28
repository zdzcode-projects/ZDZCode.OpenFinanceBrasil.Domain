using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvoiceFinancingsFinanceCharge
    {
        /// <summary>
        /// Tipo de encargo pactuado no contrato.
        /// </summary>
        [Required]
        public EnumContractFinanceChargeType ChargeType { get; set; }

        /// <summary>
        /// Campos para informações adicionais. [Restrição] Obrigatório se selecionada a opção 'OUTROS' em Tipo de encargo pactuado no contrato.Pode ser retornado NA caso a Instituição não possua essa informação.
        /// </summary>
        [Required]
        public string ChargeAdditionalInfo { get; set; }

        /// <summary>
        /// Representa o valor do encargo em percentual pactuado no contrato. Exemplo: 0.0210 (=2.1%).
        /// </summary>
        public double ChargeRate { get; set; }
    }
}
