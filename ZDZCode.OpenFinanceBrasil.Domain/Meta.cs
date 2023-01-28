using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Meta informações referente à API requisitada.
    /// </summary>
    public class Meta //confirmar com o Zids, sobre o[MaxLength e StringLength, e se é long por estar int(32) no site.

    {
        /// <summary>
        /// Número total de registros no resultado.
        /// </summary>
        [Display(Name = "Número total de registros no resultado")]
        [Required]
        [MinLength(2)]
        public long totalRecords { get; set; }

        /// <summary>
        /// Número total de páginas no resultado,
        /// </summary>
        [Display(Name = "Número total de páginas no resultado")]
        [Required]
        [MinLength(2)]
        public long totalPages { get; set; }

        /// <summary>
        /// Data e hora da consulta, conforme especificação RFC-3339, formato UTC.
        /// </summary>
        [Display(Name = "Data e hora da consulta")]
        [Required]
        [MinLength(2)]
        public DateTime requestDateTime { get; set; }

    }
}
