using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseErrorCreateConsent422 //não aceita o nome com numero, confirmar com o Zids.
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// Meta informações referente à API requisitada.
        /// </summary>
        [Required]
        public Meta Meta { get; set; }


    }
}
