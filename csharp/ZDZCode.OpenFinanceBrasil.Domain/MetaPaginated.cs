using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class MetaPaginated
    {
        /// <summary>
        /// Número total de registros no resultado.
        /// </summary>
        [Display(Name = "Número total de registros")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public int TotalRecords { get; set; }

        /// <summary>
        /// Número total de páginas no resultado.	
        /// </summary>
        [Display(Name = "Número total de registros")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public int TotalPages { get; set; }

    }
}
