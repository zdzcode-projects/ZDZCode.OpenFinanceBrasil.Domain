using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AverageTPSMetrics
    {
        /// <summary>
        /// Número médio de chamadas por segundo no dia.
        /// </summary>
        [Display(Name = "Número médio de chamadas")]
        [Required]
        [MaxLength(2)]
        [StringLength(500)]
        [MinLength(500)]
        public int CurrentDay { get; set; }

        /// <summary>
        /// Número médio de chamadas por segundo nos dias anteriores. O primeiro item do array é referente a ontem, e assim por diante. Devem ser retornados no máximo sete dias caso estejam disponíveis.
        /// </summary>
        [Display(Name = "Número médio de chamadas por segundo nos dias anteriores")]
        [Required]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public List<int> PreviousDays { get; set; } 
    }
}
