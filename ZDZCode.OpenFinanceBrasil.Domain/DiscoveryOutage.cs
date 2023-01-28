using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class DiscoveryOutage
    {
        /// <summary>
        /// Data e hora planejada do início da indisponibilidade.
        /// </summary>
        [Display(Name = "Data e hora planejada")]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]              
        public DateTime OutageTime { get; set; } 

        /// <summary>
        /// Duração prevista da indisponibilidade.
        /// </summary>
        [Display(Name = "Duração prevista")]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public string Duration { get; set; } = string.Empty;

        /// <summary>
        /// Flag que indica se a indisponibilidade é parcial (atingindo apenas alguns endpoints) ou total (atingindo todos os endpoints).
        /// </summary>
        [Display(Name = "Flag que indica a indisponibilidade")]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public bool IsPartial { get; set; }

        /// <summary>
        /// Explicação sobre os motivos da indisponibilidade.
        /// </summary>
        [Display(Name = "Explicação")]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public string Explanation { get; set; } = string.Empty;

        /// <summary>
        /// Endpoints com indisponibilidade.
        /// </summary>
        [Display(Name = "Endpoints")]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public List<string>? UnavailableEndpoints { get; set; } 
    }
}
