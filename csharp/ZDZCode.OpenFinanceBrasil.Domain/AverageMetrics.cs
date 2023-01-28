using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{   
    public class AverageMetrics
    {   /// <summary>
        /// Tempo médio de resposta em milissegundos para chamadas não autenticadas.
        /// </summary>
        [Display(Name = "Tempo resposta para chamadas não autenticadas")]
        [Required]
        [MaxLength(16000)]
        [StringLength(16000)]
        [MinLength(2)]
        public Unauthenticated Unauthenticated { get; set; }


        /// <summary>
        /// Tempo médio de resposta em milissegundos para chamadas para o nível de alta prioridade.
        /// </summary>
        [Display(Name = "Tempo de resposta para chamadas de alta prioridade")]
        [Required]
        [MaxLength(16000)]
        [StringLength(16000)]
        [MinLength(2)]
        public HighPriority HighPriority { get; set; }

        /// <summary>
        /// Tempo médio de resposta em milissegundos para chamadas para o nível de média prioridade.
        /// </summary>
        [Display(Name = "Tempo resposta para chamadas de média prioridade")]
        [Required]
        [MaxLength(16000)]
        [StringLength(16000)]
        [MinLength(2)]
        public MediumPriority MediumPriority { get; set; }

        /// <summary>
        /// Tempo médio de resposta em milissegundos para chamadas para o nível não acompanhado.
        /// </summary>
        [Display(Name = "Tempo resposta para chamadas para o nível não acompanhado.")]
        [Required]
        [MaxLength(16000)]
        [StringLength(16000)]
        [MinLength(2)]
        public Unattended Unattended { get; set; }
    }
}
