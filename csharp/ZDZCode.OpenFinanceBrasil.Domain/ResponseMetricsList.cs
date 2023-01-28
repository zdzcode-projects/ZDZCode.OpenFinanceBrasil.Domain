using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseMetricsList //Sem descrição no site
    {
       
        
        public Data Data { get; set; }



        /// <summary>
        /// Referências para outros recusos da API requisitada.
        /// </summary>
        [Display(Name = "Referências para outros recusos da API requisitada")]
        [Required]
        [MinLength(2)]
        public Links Links { get; set; }

        /// <summary>
        /// Meta informações referente à API requisitada.
        /// </summary>
        [Display(Name = "Meta informações referente à API requisitada")]
        [Required]
        [MinLength(2)]
        public Meta Meta { get; set; }

    }
}
