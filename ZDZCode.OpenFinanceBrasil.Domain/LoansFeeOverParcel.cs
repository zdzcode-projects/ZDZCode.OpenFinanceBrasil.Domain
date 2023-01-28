using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class LoansFeeOverParcel
    {
        /// <summary>
        /// Denominação da Tarifa pactuada.
        /// </summary>
        [Required]
        public string FeeName { get; set; }

        /// <summary>
        /// Sigla identificadora da tarifa pactuada.
        /// </summary>
        [Required]
        public string FeeCode { get; set; }

        /// <summary>
        /// Valor monetário da tarifa pactuada no contrato. [Restrição] Preenchimento obrigatório quando a forma de cobrança for: Mínimo, Máximo ou Fixo.
        /// </summary>
        [Required]
        public double FeeAmount { get; set; }
    }
}
