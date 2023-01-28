using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvestmentsFixedIncomeBank
    {
        /// <summary>
        /// Conjunto de informações relativas ao participante do produto de open banking
        /// </summary>
        [Required]
        public Participant Participant { get; set; }

        /// <summary>
        /// CNPJ da instituição emissora.
        /// </summary>
        [Required]
        public string IssuerInstitutionCnpjNumber { get; set; }

        /// <summary>
        /// Especificação do ativo em questão.
        /// 1. CDB
        /// 2. RDB
        /// 3. LCI
        /// 4. LCA 
        /// </summary>
        [Required]
        public EnumInvestmentsFixedIncomeBankProductType InvestimentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public InvestmentsFixedIncomeBankIndex Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public InvestmentsFixedIncomeBankInvestmentConditions InvestmentConditions { get; set; }
    }
}
