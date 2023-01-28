using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CustomerEmail
    {
        /// <summary>
        /// Indica se o email informado é o principal
        /// </summary>
        [Required]
        public bool IsMain { get; set; }

        /// <summary>
        /// Endereço de email
        /// </summary>
        [Required]
        public string Email { get; set; }
    }
}
