using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class EndpointDowntime
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
        /// Quantidade de segundos de indisponibilidade do endpoint.
        /// </summary>
        [Display(Name = "Quantidade de segundos")]
        [Required]
        [MaxLength(60)]
        [StringLength(60)]
        [MinLength(2)]
        public int PartialDowntime { get; set; }
    }
}
