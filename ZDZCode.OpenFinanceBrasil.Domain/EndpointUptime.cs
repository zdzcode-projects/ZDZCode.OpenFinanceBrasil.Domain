using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class EndpointUptime
    {
        /// <summary>
        /// URL do endpoint.
        /// </summary>
        [Display(Name = "URL")]
        [Required]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public string Url { get; set; } = string.Empty;
        /// <summary>
        /// Taxa de disponibilidade do endpoint.
        /// </summary>
        [Display(Name = "Taxa de disponibilidade")]
        [Required]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public decimal UptimeRate { get; set; }

    }
}
