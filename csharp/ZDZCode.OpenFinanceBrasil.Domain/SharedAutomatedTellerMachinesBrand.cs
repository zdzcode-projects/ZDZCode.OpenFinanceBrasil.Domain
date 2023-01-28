using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SharedAutomatedTellerMachinesBrand
    {
        /// <summary>
        /// Nome da Marca selecionada pelas Organizações.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Lista de instituições pertencentes à marca
        /// </summary>
        public SharedAutomatedTellerMachinesCompanies companies { get; set; }
    }
}
