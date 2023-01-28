using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PrizeDraw //Possui valores enum, confirmar com o Zids.
    {
        /// <summary>
        /// Intervalo de tempo regular previsto entre os sorteios. Conforme os domínios:
        /// - UNICO
        /// - DIÁRIO
        /// - SEMANAL
        /// - QUINZENAL
        /// - MENSAL
        /// - BIMESTRAL
        /// - TRIMESTRAL
        /// - QUADRIMESTRAL
        /// - SEMESTRAL
        /// - ANUAL
        /// - OUTROS
        /// </summary>
        [Required]
        public string TimeInterval { get; set; }

        /// <summary>
        /// Restrição: Campo obrigatório para complementar a informação quando selecionada a opção 'OUTROS'
        /// </summary>
        public string TimeIntervalAdditionalInfo { get; set; }

        /// <summary>
        /// Número da quantidade de sorteios previstos ao longo da vigência.
        /// </summary>
        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// Valor dos sorteios representado por múltiplo do valor de contribuição. Por exemplo: 5 vezes valor da contribuição
        /// </summary>
        [Required]
        public int PrizeMultiplier { get; set; }

        /// <summary>
        /// Modelo de sorteio que acarreta, ao título contemplado, o seu resgate total obrigatório (Resolução Normativa 384/20). Conforme os domínios: 1. true 2. false
        /// </summary>
        [Required]
        public bool EarlySettlementRaffle { get; set; }

        /// <summary>
        /// Possibilidade de realização de sorteio com previsão de que o título sorteado seja obrigatoriamente um título comercializado, desde que atingidos os requisitos definidos nas condições gerais do plano.Conforme os domínios: 1. true 2. false
        /// </summary>
        public bool MandatoryContemplation { get; set; }

        /// <summary>
        /// Campo aberto para complementar a regra dos sorteios do produto, a ser feita para cada participante.
        /// </summary>
        public string RuleDescription { get; set; }

        /// <summary>
        /// Número representativo da probabilidade mínima de contemplação nos sorteios, em porcentagem (%).
        /// </summary>
        [Required]
        public string MinimumContemplationProbability { get; set; }
    }
}
