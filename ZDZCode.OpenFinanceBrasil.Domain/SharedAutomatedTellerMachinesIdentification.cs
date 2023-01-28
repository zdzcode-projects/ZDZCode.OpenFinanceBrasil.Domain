using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SharedAutomatedTellerMachinesIdentification
    {
        /// <summary>
        /// Nome do proprietário do terminal de Autoatendimento Compartilhado
        /// </summary>
        [Required]
        public string ownerName { get; set; }
    }
}
