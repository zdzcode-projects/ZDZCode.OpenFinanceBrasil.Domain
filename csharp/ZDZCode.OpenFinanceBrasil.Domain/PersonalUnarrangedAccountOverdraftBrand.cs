using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalUnarrangedAccountOverdraftBrand
    {
        /// <summary>
        /// Nome da Marca reportada pelo participante do Open Banking. O conceito a que se refere a 'marca' é em essência uma promessa da empresa em fornecer uma série específica de atributos, benefícios e serviços uniformes aos clientes.
        /// </summary>
        [Required]
        public string name { get; set; }

        /// <summary>
        /// Companies traz uma lista de todas as instituições da Marca
        /// </summary>
        [Required]
        public PersonalUnarrangedAccountOverdraftCompany companies { get; set; }

    }
}
