using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class EconomicActivity
    {
        /// <summary>
        /// Traz o código do ramo da atividade principal da empresa consultada, segundo padrão CNAE (Classificação Nacional de Atividades Econômicas).
        /// </summary>
        [Required]
        public int Code { get; set; }

        /// <summary>
        /// Indica se é o ramo principal de atividade da empresa quando true e se é o ramo secundário quando false.
        /// </summary>
        [Required]
        public bool IsMain { get; set; }
    }
}
