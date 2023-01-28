using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class MinimumBalance
    {
        /// <summary>
        /// Saldo mínimo exigido nos Termos e condições contratuais, que regem as contas comercializadas.
        /// </summary>
        [Required]
        public decimal Value { get; set; }

        /// <summary>
        /// Moeda referente ao valor mínimo da Tarifa, segundo modelo ISO-4217
        /// </summary>
        [Required]
        public string Currency { get; set; }

    }
}
