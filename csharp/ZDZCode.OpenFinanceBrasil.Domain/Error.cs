using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Error
    {
        /// <summary>
        /// Código de erro específico do endpoint
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Título legível por humanos deste erro específico
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Descrição legível por humanos deste erro específico
        /// </summary>
        [Required]
        public string Detail { get; set; }
    }
}
