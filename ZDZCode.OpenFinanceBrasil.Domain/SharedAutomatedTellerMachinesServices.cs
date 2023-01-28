using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SharedAutomatedTellerMachinesServices
    {
        /// <summary>
        /// Lista com os nomes de serviços prestados.
        /// </summary>
        public EnumSharedAutomatedTellerMachinesServicesNames name { get; set; }

        /// <summary>
        /// Lista com os códigos de serviços prestados.
        /// </summary>
        public EnumSharedAutomatedTellerMachinesServicesCodes code { get; set; }

        /// <summary>
        /// Texto livre para complementar informação relativa ao Serviço disponível, quando for preenchida a opção 'OUTROS_PRODUTOS_SERVICOS'
        /// </summary>
        public string additionalInfo { get; set; }
    }
}
