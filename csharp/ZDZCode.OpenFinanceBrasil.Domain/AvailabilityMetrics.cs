using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{ //confirmar com o Zids
    public class AvailabilityMetrics
    {
        /// <summary>
        /// Tempos de uptime por endpoint.
        /// </summary>
        [Display(Name = "Tempos de uptime")]
        [Required]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public Uptime Uptime { get; set; }
        
        /// <summary>
        /// Tempos de downtime por endpoint.
        /// </summary>
        [Display(Name = "Tempos de downtime")]
        [Required]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public Downtime Downtime { get; set; }
    }
}
