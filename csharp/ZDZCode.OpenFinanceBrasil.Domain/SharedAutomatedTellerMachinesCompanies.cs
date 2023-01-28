using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SharedAutomatedTellerMachinesCompanies
    {
        /// <summary>
        ///
        /// </summary>
        public SharedAutomatedTellerMachines sharedAutomatedTellerMachines { get; set; }

        /// <summary>
        /// Nome da Instituição, pertencente à Marca.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Número completo do CNPJ da instituição.
        /// </summary>
        public string cnpjNumber { get; set; }

        /// <summary>
        /// URL de link para lista complementar com os nomes e CNPJs agrupados para o caso instituições ofertantes de produtos e serviços com as mesmas características.
        /// </summary>
        public string urlComplementaryList { get; set; }
    }
}
