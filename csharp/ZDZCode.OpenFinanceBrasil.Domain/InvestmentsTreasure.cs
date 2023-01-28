using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvestmentsTreasure
    {
        /// <summary>
        /// Conjunto de informações relativas ao participante do produto de open banking
        /// </summary>
        public Participant Participant { get; set; }

        /// <summary>
        /// Especifica o tipo de ativo negociado:
        /// Tesouro direto
        /// </summary>
        [Required]
        public EnumInvestmentsTreasureInvestmentType InvestmentType { get; set; }

        /// <summary>
        /// Distribuição por frequência.
        /// </summary>
        [Required]
        public NoIdentificationFrequencyDistribution CustodyFee { get; set; }

        /// <summary>
        /// Distribuição por frequência.
        /// </summary>
        [Required]
        public NoIdentificationFrequencyDistribution LoadingRate { get; set; }
    }
}
