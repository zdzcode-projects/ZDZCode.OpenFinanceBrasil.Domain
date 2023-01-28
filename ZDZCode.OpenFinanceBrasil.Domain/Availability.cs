using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Availability
    {
        /// <summary>
        /// Lista com os dias da semana.
        /// </summary>
        [Required]
        public List<Standard> standards { get; set; }

        /// <summary>
        /// Informações sobre as exceções de abertura.
        /// </summary>
        public string Exception { get; set; }

        /// <summary>
        /// Define se possui acesso ao público. True ou False.
        /// </summary>
        public string IsPublicAccessAllowed { get; set; }
    }
}
