using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class LatePayment
    {
        /// <summary>
        /// Conforme manual SUSEP: Prazo máximo (contínuo ou intermitente) em meses que o título fica suspenso por atraso de pagamento, antes de ser cancelado (não aplicável a pagamento único).
        /// </summary>
        [Required]
        public int SuspensionMonths { get; set; }

        /// <summary>
        /// Alteração do prazo de vigência original, pela suspensão (não aplicável a pagamento único). A considerar os seguintes domínios: 1. true 2. false
        /// </summary>
        [Required]
        public bool PeriodExtensionOption { get; set; }
    }
}
