using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SurvivalPensionLoadingAntecipated
    {
        /// <summary>
        /// Percentual mínimo de carregamento cobrada quando do pagamento do prêmio/ contribuição. Em %.    
        /// </summary>
        [Required]
        public string MinValue { get; set; }

        /// <summary>
        /// Percentual máximo de carregamento cobrada quando do pagamento do prêmio/ contribuição. Em %.
        /// </summary>
        [Required]
        public string MaxValue { get; set; }
    }
}
