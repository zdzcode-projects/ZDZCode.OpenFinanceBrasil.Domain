using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SurvivalPensionGracePeriod
    {
        /// <summary>
        /// Prazo em dias de carência para resgate Para Coletivos: Valor máximo da carência.
        /// </summary>
        [Required]
        public int Redemption { get; set; }

        /// <summary>
        /// Prazo em dias de carência entre pedidos de resgate Para Coletivos: Valor máximo da carência
        /// </summary>
        [Required]
        public int BetweenRedemptionRequests { get; set; }

        /// <summary>
        /// Prazo em dias de carência para portabilidade (entre empresas diferentes).
        /// </summary>
        [Required]
        public int Portability { get; set; }

        /// <summary>
        /// Prazo em dias de carência entre pedidos de portabilidade (entre empresas diferentes).
        /// </summary>
        [Required]
        public int BetweenPortabilityRequests { get; set; }


    }
}
