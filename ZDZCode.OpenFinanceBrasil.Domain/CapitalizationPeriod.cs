using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CapitalizationPeriod
    {
        /// <summary>
        /// Taxa que remunera a parte da mensalidade destinada a formar o Capital, ou seja, a Provisão Matemática de Resgate, também chamada de saldo de capitalização. Em porcentagem ao mês (% a.m.).
        /// </summary>
        [Required]
        public string InterestRate { get; set; }

        /// <summary>
        /// Índice utilizado na atualização dos pagamentos mensais (para títulos com mais de 12 meses de vigência) (não aplicável a pagamento único).
        /// </summary>
        [Required]
        public CapitalizationBondsProductUpdateIndex UpdateIndex { get; set; }

        /// <summary>
        /// Restrição: Campo obrigatório para complementar a informação quando selecionada a opção 'OUTROS'
        /// </summary>
        public string UpdateIndexAdditionalInfo { get; set; }

        /// <summary>
        /// [Corresponde ao pagamento efetuado pelo subscritor à sociedade de capitalização para a aquisição do título de capitalização, podendo ser única, periódica ou mensal (Resolução CNSP 384/20). Valores em reais (R$). Esclarecimentos adicionais SUSEP. Na modalidade Tradicional, informar a faixa de valor mínimo e máximo em R$ de contribuição ao plano. Para as demais modalidades, informar a lista com os valores permitidos de contribuição ao plano. Em todas as situações indicar para qual periodicidade de pagamento se aplicam os valores: pagamento mensal, pagamento único ou periódico.]
        /// </summary>
        [Required]
        public List<CapitalizationPeriodContributionAmount> ContributionAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<CapitalizationBondsProductEarlyRedemption> EarlyRedemptions { get; set; }

        /// <summary>
        /// Percentual mínimo da soma das contribuições efetuadas que poderá ser resgatado ao final da vigência, tendo como condição os pagamentos das parcelas nos respectivos vencimentos.
        /// </summary>
        [Required]
        public string RedemptionPercentageEndTerm { get; set; }

        /// <summary>
        /// Intervalo de tempo mínimo entre contratação e resgate do direito, em meses.
        /// </summary>
        [Required]
        public int GracePeriodRedemption { get; set; }
    }
}
