using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalCreditCardBrand
    {
        /// <summary>
        /// Nome da Marca selecionada pelas Organizações
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Companies traz uma lista de todas as instituições da Marca
        /// </summary>
        [Required]
        public PersonalCreditCardCompanies companies { get; set; }
    }
}
