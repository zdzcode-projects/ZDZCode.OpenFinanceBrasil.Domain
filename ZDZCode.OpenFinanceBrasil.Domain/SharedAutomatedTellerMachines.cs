using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SharedAutomatedTellerMachines
    {
        /// <summary>
        ///
        /// </summary>
        public SharedAutomatedTellerMachinesIdentification identification { get; set; }

        /// <summary>
        ///
        /// </summary>
        public PostalAddress postalAddress { get; set; }

        /// <summary>
        ///
        /// </summary>
        public Availability availability { get; set; }

        /// <summary>
        ///
        /// </summary>
        public SharedAutomatedTellerMachinesServices services { get; set; }
    }
}
