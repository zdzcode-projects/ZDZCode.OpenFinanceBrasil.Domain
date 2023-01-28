using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BusinessAccountsBrand
    {
        /// <summary>
        /// Nome da Instituição, pertencente à marca, responsável pela comercialização dos produtos e serviços.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Companies traz uma lista de todas as instituições da Marca.
        /// </summary>
        [Required]
        public List<BusinessAccountsCompany> Companies { get; set; }
    }
}
