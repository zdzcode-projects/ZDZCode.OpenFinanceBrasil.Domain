using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class LinksPaginated
    {

        /// <summary>
        /// URI completo que gerou a resposta atual.
        /// </summary>
        [Display(Name = "URI completo")]
        [Required]
        [MaxLength(500)]
        [StringLength(500)]
        [MinLength(2)]
        public string Self { get; set; } = string.Empty;

        /// <summary>
        /// URI da primeira página que originou essa lista de resultados.
        /// </summary>
        [Display(Name = "URI da primeira página")]       
        [MaxLength(500)]
        [StringLength(500)]
        public string? First { get; set; }

        /// <summary>
        /// URI da página anterior dessa lista de resultados.
        /// </summary>
        [Display(Name = "URI da página anterior")]
        [MaxLength(500)]
        [StringLength(500)]
        public string? Prev { get; set; }

        /// <summary>
        /// URI da próxima página dessa lista de resultados.	
        /// </summary>
        [Display(Name = "URI da próxima página")]
        [MaxLength(500)]
        [StringLength(500)]
        public string? Next { get; set; }

        /// <summary>
        /// URI da última página dessa lista de resultados.	
        /// </summary>
        [Display(Name = "URI da última página")]
        [MaxLength(500)]
        [StringLength(500)]
        public string? Last { get; set; } 



    }
}
