using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseError
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// Meta informações referente à API requisitada.
        /// </summary>
        public Meta Meta { get; set; } 
    }
}
