using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalLoanBrand
    {
        /// <summary>
        /// Nome da marca proprietária da dependência (titular).
        /// </summary>
        [Required]
        public string name { get; set; }

        /// <summary>
        /// Companies traz uma lista de todas as instituições da Marca.
        /// </summary>
        [Required]
        public PersonalLoanCompany companies { get; set; }
    }
}
