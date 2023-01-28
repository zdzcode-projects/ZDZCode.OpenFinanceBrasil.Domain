using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalUnarrangedAccountOverdraftFee
    {
        /// <summary>
        /// Lista das Tarifas cobradas sobre Serviços Prioritários
        /// </summary>
        [Required]
        public UnarrangedAccountOverdraftService priorityServices { get; set; }
    }
}
