using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CapitalizationPeriodContributionAmount
    {
        /// <summary>
        /// Intervalo de tempo regular previsto entre os sorteios. Conforme os domínios:
        /// 1. Único
        /// 2. Diário
        /// 3. Semanal
        /// 4. Quinzenal
        /// 5. Mensal
        /// 6. Bimestral
        /// 7. Trimestral
        /// 8. Quadrimestral
        /// 9. Semestral
        /// 10. Anual
        /// 11. Outros
        /// </summary>
        [Required]
        public EnumContributionAmountPeriodicity Periodicity { get; set; }

        /// <summary>
        /// Restrição: Campo obrigatório para complementar a informação quando selecionada a opção 'OUTROS'
        /// </summary>
        public string PeriodicityAdditionalInfo { get; set; }

        /// <summary>
        /// Condicional: Quando modalidade for igual 'TRADICIONAL' Valor mínimo correspondente ao pagamento efetuado pelo subscritor à sociedade de capitalização.
        /// </summary>
        [Required]
        public string Minimum { get; set; }

        /// <summary>
        /// Condicional: Quando modalidade for igual 'TRADICIONAL' Valor máximo correspondente ao pagamento efetuado pelo subscritor à sociedade de capitalização.
        /// </summary>
        [Required]
        public string Maximum { get; set; }

        /// <summary>
        /// Condicional: Quando modalidade for diferente de 'TRADICIONAL' Lista com os valores permitidos de contribuição ao plano.
        /// </summary>
        [Required]
        public int AllowedValue { get; set; }
    }
}
