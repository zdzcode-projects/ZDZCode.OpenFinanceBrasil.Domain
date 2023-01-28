using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvocationMetrics
    {
        /// <summary>
        /// Número de chamadas não autenticadas.
        /// </summary>
        [Display(Name = "Número de chamadas não autenticadas")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public Unauthenticated Unauthenticated { get; set; }

        /// <summary>
        /// Número de chamadas para o nível de alta prioridade.
        /// </summary>
        [Display(Name = "Número de chamadas para o nível de alta prioridade")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public HighPriority HighPriority { get; set; }

        /// <summary>
        /// Tempo médio de resposta em milissegundos para chamadas no dia atual.
        /// </summary>
        [Display(Name = "Tempo médio de resposta em milissegundos para chamadas no dia atual")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public MediumPriority MediumPriority { get; set; }

        /// <summary>
        /// Número de chamadas para o nível de média prioridade.
        /// </summary>
        [Display(Name = "Número de chamadas para o nível de média prioridade")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public Unattended Unattended { get; set; }
    }
}
