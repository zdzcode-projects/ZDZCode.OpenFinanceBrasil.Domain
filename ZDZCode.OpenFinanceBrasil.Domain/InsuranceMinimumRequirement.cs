using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InsuranceMinimumRequirement
    {
        /// <summary>
        /// A considerar os domínios abaixo:
        /// 1. Coletivo;
        /// 2. Individual
        /// 3. Ambas(Coletivo e Individual)
        /// </summary>
        [Required]
        public string ContractType { get; set; }

        /// <summary>
        /// Campo aberto (possibilidade de incluir URL)
        /// </summary>
        public EnumContractType ContractingMinRequirement { get; set; }
    }
}
