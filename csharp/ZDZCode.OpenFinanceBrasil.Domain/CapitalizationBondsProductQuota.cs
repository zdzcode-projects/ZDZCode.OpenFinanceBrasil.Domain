using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CapitalizationBondsProductQuota
    {
        /// <summary>
        /// Número da parcela.
        /// </summary>
        [Required]
        public int Quota { get; set; }

        /// <summary>
        /// Percentual da contribuição destinado à constituição de capital referente ao direito de resgate. (Resolução CNSP 384/20) Em porcentagem(%).
        /// </summary>
        [Required]
        public string CapitalizationQuota { get; set; }

        /// <summary>
        /// Percentual da contribuição destinado a custear os sorteios, se previstos no plano. (Resolução CNSP 384/20) Em porcentagem(%).
        /// </summary>
        [Required]
        public string RaffleQuota { get; set; }

        /// <summary>
        /// 	Percentual da contribuição destinado aos custos de despesas com corretagem, colocação e administração do título de capitalização, emissão, divulgação, lucro da sociedade de capitalização e eventuais despesas relativas ao custeio da contemplação obrigatória e da distribuição de bônus. (Resolução CNSP 384/20) Em porcentagem(%).
        /// </summary>
        [Required]
        public string ChargingQuota { get; set; }
    }
}
