using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Uptime
    {
        /// <summary>
        /// Taxa de disponibilidade (considerando todos os serviços ativos ao mesmo tempo).
        /// </summary>
        [Display(Name = "Taxa de disponibilidade")]
        [Required]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public decimal GeneralUptimeRate { get; set; }

        /// <summary>
        /// Tempos de uptime por endpoint.
        /// </summary>
        [Display(Name = "Tempos de uptime")]
        [Required]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public EndpointUptime Endpoins { get; set; }

    }
}
