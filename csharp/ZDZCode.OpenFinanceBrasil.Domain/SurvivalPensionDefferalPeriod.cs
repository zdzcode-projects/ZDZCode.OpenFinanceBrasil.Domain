using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SurvivalPensionDefferalPeriod
    {
        /// <summary>
        /// Taxa de juros mensal garantida que remunera o plano durante a fase de diferimento/acumulação.
        /// </summary>
        public string InterestRate { get; set; }

        /// <summary>
        /// Índice utilizado na atualização do prêmio e do capital segurado, caso critério de atualização por meio de índice:
        /// 1. IPCA(IBGE);
        /// 2. IGP-M(FGV);
        /// 3. INPC(IBGE).
        /// </summary>
        public UpdateIndex UpdateIndex { get; set; }

        /// <summary>
        /// Para produtos do tipo PDR e VDR, indicação do índice de ampla divulgação utilizados como garantia mínima de desempenho.
        /// </summary>
        public string OtherMinimumPerformanceGarantees { get; set; }

        /// <summary>
        /// Percentual de reversão de excedente financeiro na concessão. Em %.
        /// </summary>
        public string ReversalFinancialResults { get; set; }

        /// <summary>
        /// [Valor mínimo de prêmio/contribuição]
        /// </summary>
        public List<SurvivalPensionMinimumPremium> MinimumPremiums { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<string> PremiumPaymentMethods { get; set; }

        /// <summary>
        /// Se ficam permitidos aportes extraordinários. A considerar os seguintes domínios:
        /// 1. true
        /// 2. false
        /// </summary>
        public bool PermissionExtraordinaryContributions { get; set; }

        /// <summary>
        /// Se ficam permitidos pagamentos financeiros programados. A considerar os seguintes domínios:
        /// 1. true
        /// 2. false
        /// </summary>
        public bool PermissionScheduledFinancialPayments { get; set; }

        /// <summary>
        /// Prazo de carência
        /// </summary>
        public SurvivalPensionGracePeriod GracePeriod { get; set; }

        /// <summary>
        /// Prazo em dias para pagamento do resgate
        /// </summary>
        public int RedemptionPaymentTerm { get; set; }

        /// <summary>
        /// Prazo em dias para pagamento da portabilidade (entre empresas diferentes).
        /// </summary>
        public int PortabilityPaymentTerm { get; set; }

        /// <summary>
        /// [Fundos de Investimento (por fundo).]
        /// </summary>
        public List<SurvivalPensionInvestimentFund> InvestmentFunds { get; set; }
    }
}
