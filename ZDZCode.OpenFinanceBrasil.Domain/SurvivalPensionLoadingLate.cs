using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SurvivalPensionLoadingLate
    {
        /// <summary>
        /// Percentual mínimo de taxa de carregamento cobrado quando da efetivação de resgate ou portabilidade.
        /// </summary>
        [Required]
        public string MinValue { get; set; }

        /// <summary>
        /// Percentual máximo de taxa de carregamento cobrado quando da efetivação de resgate ou portabilidade.
        /// </summary>
        [Required]
        public string MaxValue { get; set; }
    }
}
