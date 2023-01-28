using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{  
    public class Application
    {
        /// <summary>
        /// .......................................
        /// </summary>
        [Display(Name = "....................... ")]
        [MaxLength(3)]
        [StringLength(500)]
        [MinLength(500)]
        public EnumPriceInterval Interval { get; set; }
        public Indexer Indexer { get; set; }
        public Customer Customers { get; set; }
    }

}

