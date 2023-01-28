using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class LoansContractedFee
    {
        /// <summary>
        /// Denominação da Tarifa pactuada
        /// </summary>
        [Required]
        public string FeeName { get; set; }

        /// <summary>
        /// Sigla identificadora da tarifa pactuada
        /// </summary>
        [Required]
        public string FeeCode { get; set; }

        /// <summary>
        /// Tipo de cobrança para a tarifa pactuada no contrato.
        /// </summary>
        [Required]
        public EnumContractFeeChargeType FeeChargeType { get; set; }

        /// <summary>
        /// "Forma de cobrança relativa a tarifa pactuada no contrato. (Vide Enum) - Mínimo - Máximo - Fixo - Percentual"
        /// </summary>
        [Required]
        public EnumContractFeeCharge FeeCharge { get; set; }

        /// <summary>
        /// Valor monetário da tarifa pactuada no contrato. Preenchimento obrigatório quando a forma de cobrança for: Mínimo, Máximo ou Fixo.
        /// </summary>
        [Required]
        public double FeeAmount { get; set; }

        /// <summary>
        /// 	É o valor da tarifa em percentual pactuada no contrato. Deve-se informar 4 casas decimais, mesmo que preenchidas com zeros. Exemplo: 0.2000 [Restrição] Preenchimento obrigatório quando a forma de cobrança for Percentual.Exemplo: 0.0150 = 1,5%.
        /// </summary>
        [Required]
        public double FeeRate { get; set; }
    }
}
