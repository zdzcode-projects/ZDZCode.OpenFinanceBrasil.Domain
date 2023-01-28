using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvestmentsFixedIncomeBankIndex
    {
        /// <summary>
        /// Índice utilizado como referência para a correção da rentabilidade e/ou rendimentos do ativo (p.ex. CDI).
        /// Pré-fixado, em linha com padronização da B3:
        /// CDI
        /// DI
        /// TR
        /// IPCA
        /// IGP-M
        /// IGP-DI
        /// INPC
        /// BCP
        /// TLC
        /// Selic
        /// Outros
        /// </summary>
        [Required]
        public EnumInvestmentsFixedIncomeBankIndexer Indexer { get; set; }

        /// <summary>
        /// Campo a ser preenchido pelas participantes quando houver ‘Outros’ no campo ‘Indexador’.
        /// </summary>
        public string IndexerAdditionalInfo { get; set; }

        /// <summary>
        /// Distribuição por frequência.
        /// </summary>
        [Required]
        public NoIdentificationFrequencyDistribution IssueRemunerationRate { get; set; }
    }
}
