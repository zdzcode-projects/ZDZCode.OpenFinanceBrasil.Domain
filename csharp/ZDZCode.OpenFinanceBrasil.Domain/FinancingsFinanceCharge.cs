using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class FinancingsFinanceCharge
    {
        /// <summary>
        /// Tipo de encargo pactuado no contrato.
        /// </summary>
        [Required]
        public EnumContractFinanceChargeType ChargeType { get; set; }

        /// <summary>
        /// Campo de preenchimento obrigatório se selecionada a opção 'OUTROS' em Tipo de encargo pactuado no contrato.[Restrição] Obrigatório se selecionada a opção 'OUTROS' em Tipo de encargo pactuado no contrato.
        /// </summary>
        [Required]
        public string ChargeAdditionalInfo { get; set; }

        /// <summary>
        /// Representa o valor do encargo em percentual pactuado no contrato. Exemplo: 0.0210 (=2.1%).
        /// </summary>
        public double ChargeRate { get; set; }
    }
}
