using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseBusinessCustomersIdentification
    {
        /// <summary>
        /// [Conjunto de informações relativas a Identificação ou seja a ação e o efeito de identificar de forma única a pessoa jurídica através de seus dados cadastrais]
        /// </summary>
        [Required]
        public List<BusinessIdentificationData> Data { get; set; }

        /// <summary>
        /// Referências para outros recusos da API requisitada.
        /// </summary>
        [Required]
        public Links Links { get; set; }

        /// <summary>
        /// Meta informações referente à API requisitada.
        /// </summary>
        [Required]
        public Meta Meta { get; set; }
    }
}
