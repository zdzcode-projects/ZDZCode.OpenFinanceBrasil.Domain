using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class GracePeriod
    {
        /// <summary>
        /// Informar o prazo de carência
        /// </summary>
        [Required]
        public int Amount { get; set; }

        /// <summary>
        /// Informar o critério de carência para a cobertura:
        /// Dias
        /// Meses
        /// Não se aplica
        /// </summary>
        [Required]
        public EnumGracePeriodUnit Unit { get; set; }
    }
}
