using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SurvivalPensionMinimumPremium //possui valores enum no site, confirmar com o Zids.
    {
        /// <summary>
        /// Moeda referente ao valor monetário, seguindo o modelo ISO-4217.
        /// </summary>
        public CurrencyCode Currency { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string Periodicity { get; set; }

        /// <summary>
        /// Valor mínimo em R$ de prêmio/ contribuição aceita pela sociedade ao plano (identificar valor mensal e/ou aporte único).
        /// </summary>
        public string Amount { get; set; }
    }
}
