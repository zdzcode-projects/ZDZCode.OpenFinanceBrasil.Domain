using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AutomotiveGeoGraphicScope
    {
        /// <summary>
        /// [Listagem de abrangência geográfica do produto para fins de cada cobertura:
        /// 1. Nacional
        /// 2. Regional
        /// 3. Internacional
        /// 4. Apenas outros países
        ///Observação: o campo permite a seleção de mais de um item(multivalorado)]
        /// </summary>
        public List<string> Coverages { get; set; }

        /// <summary>
        /// Detalhamento das regiões e países de abrangência.
        /// </summary>
        public string Details { get; set; }
    }
}
