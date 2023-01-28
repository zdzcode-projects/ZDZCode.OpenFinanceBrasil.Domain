using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Downtime
    {
        /// <summary>
        /// Quantidade de segundos de downtime (considerando qualquer api em downtime).
        /// </summary>
        [Display(Name = "Quantidade de segundos de downtime")]
        [Required]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public int GeneralDowntime { get; set; }

        /// <summary>
        /// Quantidade de segundos de indisponibilidade agendada.
        /// </summary>
        [Display(Name = "Quantidade de segundos de indisponibilidade")]
        [Required]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public int ScheduledOutage { get; set; }

        /// <summary>
        /// Tempos de downtime por endpoint.
        /// </summary>
        [Display(Name = "Tempos de downtime")]
        [Required]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public EndpointDowntime Endpoints { get; set; }
    }
}
