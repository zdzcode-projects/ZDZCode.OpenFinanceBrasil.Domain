using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InformedPatrimony
    {
        /// <summary>
        /// Valor do patrimônio informado. Expresso em valor monetário com 4 casas decimais. Patrimônio é o conjunto de bens vinculado a uma pessoa ou a uma entidade.
        /// </summary>
        [Required]
        public double Amount { get; set; }

        /// <summary>
        /// Moeda referente ao valor do patrimônio, segundo modelo ISO-4217.
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        /// Ano de referência do Patrimônio, conforme especificação RFC-3339.
        /// </summary>
        [Required]
        public int Year { get; set; }
    }
}
