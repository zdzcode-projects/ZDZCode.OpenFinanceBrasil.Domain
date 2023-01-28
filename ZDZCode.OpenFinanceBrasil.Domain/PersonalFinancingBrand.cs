using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalFinancingBrand
    {
        /// <summary>
        /// Nome da Marca reportada pelo participante do Open Banking. O conceito a que se refere a 'marca' é em essência uma promessa da empresa em fornecer uma série específica de atributos, benefícios e serviços uniformes aos clientes.
        /// </summary>
        [Required]
        public string name { get; set; }

        /// <summary>
        /// Lista de instituições pertencentes à marca.
        /// </summary>
        [Required]
        public PersonalFinancingCompany companies { get; set; }
    }
}
