using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvestmentsFundAdmin
    {
        /// <summary>
        /// Razão social da pessoa jurídica autorizada pela CVM para o exercício de administrador de carteiras de valores mobiliários e responsável pela administração do fundo.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// CNPJ do administrador.
        /// </summary>
        [Required]
        public string CnpjNumber { get; set; }
    }
}
