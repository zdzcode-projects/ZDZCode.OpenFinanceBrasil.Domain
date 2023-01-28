using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Data
    {
        /// <summary>
        /// Lista de códigos de status da API.
        /// </summary>
        [Display(Name = "Lista de códigos de status")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public DiscoveryStatus Status { get; set; }

        /// <summary>
        /// Data e hora que as métricas foram requisitadas.
        /// </summary>
        [Display(Name = "Data e hora que as métricas foram requisitadas")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public DateTime RequestTime { get; set; }

        /// <summary>
        /// Lista de códigos de status da API.
        /// </summary>
        [Display(Name = "Lista de códigos de status")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public AvailabilityMetrics Availability { get; set; }

        /// <summary>
        /// Número de chamadas em cada nível e prioridade.
        /// </summary>
        [Display(Name = "Número de chamadas em cada nível e prioridade")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public InvocationMetrics Invocations { get; set; }

        /// <summary>
        /// Tempo médio de reposta em milissegundos em cada nível e prioridade.
        /// </summary>
        [Display(Name = "Tempo médio de reposta em milissegundos em cada nível e prioridade")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public AverageMetrics AverageResponse { get; set; }

        /// <summary>
        /// Transações em média por segundo.
        /// </summary>
        [Display(Name = "Transações em média por segundo")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public AverageTPSMetrics AverageTps { get; set; }

        /// <summary>
        /// Número máximo de transações por segundo.
        /// </summary>
        [Display(Name = "Número máximo de transações por segundo")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public PeakTPSMetrics PeakTps { get; set; }

        /// <summary>
        /// Número de chamadas que resultaram em erro devido ao servidor.
        /// </summary>
        [Display(Name = "Número de chamadas que resultaram em erro devido ao servidor")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public ErrorMetrics Errors { get; set; } //confirmar com o Zids

        /// <summary>
        /// Número de chamadas rejeitadas devido aos limites.
        /// </summary>
        [Display(Name = "Número de chamadas rejeitadas devido aos limites")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public RejectionMetrics Rejections { get; set; }

        /// <summary>
        /// Organização controladora do grupo de instituições financeiras.
        /// </summary>
        [Required]
        public BusinessAccountsBrand brand { get; set; }

        //confirmar com o Zids. Yuri
        /// <summary>
        /// Organização controladora do grupo de instituições financeiras.
        /// </summary>
        //[Required]
        //public BusinessCreditCardBrand brand { get; set; }
    }
}
