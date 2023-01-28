using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SurvivalPensionGrantPeriodBenefit
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<string> IncomeModalities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<string> BiometricTable { get; set; }

        /// <summary>
        /// Taxa de juros garantida utilizada para conversão em renda. Em %
        /// </summary>
        public string InterestRate { get; set; }

        /// <summary>
        ///Índice utilizado na atualização do prêmio e do capital segurado, caso critério de atualização por meio de índice:
        /// 1. IPCA(IBGE);
        /// 2. IGP-M(FGV);
        /// 3. INPC(IBGE).
        /// </summary>
        public UpdateIndex UpdateIndex { get; set; }

        /// <summary>
        /// Percentual de reversão de excedente financeiro na concessão. Em %.
        /// </summary>
        public string ReversalFinancialResults { get; set; }

        /// <summary>
        /// [Fundos de Investimento (por fundo).]
        /// </summary>
        public List<SurvivalPensionInvestimentFund> InvestmentFunds { get; set; }
    }
}
