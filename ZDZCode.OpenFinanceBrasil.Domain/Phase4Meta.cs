using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Meta informações referente à API requisitada.
    /// </summary>
    public class Phase4Meta
    {
        /// <summary>
        /// Número total de registros no resultado
        /// </summary>
        [Required]
        public int TotalRecords { get; set; }

        /// <summary>
        /// Número total de páginas no resultado
        /// </summary>
        [Required]
        public int TotalPages { get; set; }
    }
}
