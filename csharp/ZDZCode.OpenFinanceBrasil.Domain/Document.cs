using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Document
    {
        /// <summary>
        /// Número do documento de identificação oficial do usuário.
        /// </summary>
        [Required]
        public string Identification { get; set; }

        /// <summary>
        /// Tipo do documento de identificação oficial do usuário.
        /// </summary>
        [Required]
        public string Rel { get; set; }
    }
}
