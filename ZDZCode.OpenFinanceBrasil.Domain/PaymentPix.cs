using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Objeto contendo dados do pagameto como moeda e valor.
    /// </summary>
    public class PaymentPix
    {
        /// <summary>   
        /// Valor da transação com 2 casas decimais.
        /// </summary>
        [Required]
        public string Amount { get; set; }

        /// <summary>
        /// Código da moeda nacional segundo modelo ISO-4217, ou seja, 'BRL'. Todos os valores monetários informados estão representados com a moeda vigente do Brasil.
                /// </summary>
        [Required]
        public string Currency { get; set; }
    }
}
