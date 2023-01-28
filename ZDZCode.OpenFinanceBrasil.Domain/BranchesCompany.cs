using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BranchesCompany //Vazio no site
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public string CnpjNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public string UrlComplementaryList { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<Branch> Branches { get; set; }
    }
}
