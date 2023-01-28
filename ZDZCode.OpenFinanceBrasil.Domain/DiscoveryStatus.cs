using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class DiscoveryStatus
    {
        [Display(Name = "Tipo de telefone")]
        [EnumDataType(typeof(EnumStatusCode))]
        public EnumStatusCode Code { get; set; }

        /// <summary>
        /// Fornece uma explicação da interrupção atual que pode ser exibida para um cliente final.
        /// </summary>
        [Display(Name = "Explicação da interrupção")]
        [MaxLength(500)]
        [Required]
        [StringLength(500)]
        [MinLength(2)]
        public string Explanation { get; set; } = string.Empty;

        /// <summary>
        /// A data e hora em que a interrupção atual foi detectada.
        /// </summary>
        [Display(Name = "Data e hora da interrupção atual")]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public DateTime? DetectionTime { get; set; }

        /// <summary>
        /// A data e hora em que o serviço completo deve continuar (se conhecido).
        /// </summary>
        [Display(Name = "A data e hora em que o serviço completo deve continuar")]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public DateTime? ExpectedResolutionTime { get; set; }

        /// <summary>
        /// A data e hora em que esse status foi atualizado pela última vez pelo titular dos dados.
        /// </summary>
        [Display(Name = "A data e hora em que esse status foi atualizado")]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Endpoints com indisponibilidade.
        /// </summary>
        [Display(Name = "Endpoints com indisponibilidade")]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public List<string>? UnavailableEndpoints { get; set; }
    }
}
