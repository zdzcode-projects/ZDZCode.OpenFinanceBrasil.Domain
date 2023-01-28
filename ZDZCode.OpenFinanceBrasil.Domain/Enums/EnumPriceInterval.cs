using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumPriceInterval
    {
        //conferir com o zdz
        /// <summary>
        /// interval
        /// </summary>
        PRIMEIRA_FAIXA = 1,

        /// <summary>
        /// interval
        /// </summary>
        SEGUNDA_FAIXA = 2,

        /// <summary>
        /// interval
        /// </summary>
        TERCEIRA_FAIXA = 3,

        /// <summary>
        /// interval
        /// </summary>
        [Description("Cessão de direitos creditórios")]
        QUARTA_FAIXA = 4,
    }
}
