using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InsurancePensionBenefitRecalculation
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<string> Criterias { get; set; }

        /// <summary>
        /// [Índice utilizado na atualização da PMBaC:
        /// 1. IPCA(IBGE)
        /// 2. IGP-M(FGV)
        /// 3. INPC(IBGE)]
        /// </summary>
        [Required]
        public List<EnumPersonalUpdateIndex> UpdateIndexes { get; set; }
    }
}
