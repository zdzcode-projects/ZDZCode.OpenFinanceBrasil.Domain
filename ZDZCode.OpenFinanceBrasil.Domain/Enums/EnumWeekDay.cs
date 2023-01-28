using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumWeekDay
    {
        /// <summary>
        /// Primeiro dia da semana
        /// </summary>
        [Description("Domingo, primeiro dia da semana ")]
        DOMINGO = 1,

        /// <summary>
        /// Segundo dia da  semana 
        /// </summary>
        [Description("Segunda-feira, segundo dia da semana")]
        SEGUNDA_FEIRA = 2,

        /// <summary>
        // Terceiro dia da semana 
        /// </summary>
        [Description("Terça-feira, terceiro dia da semana")]
        TERCA_FEIRA = 3,

        /// <summary>
        /// Quarto dia da semana 
        /// </summary>
        [Description("Quarta-feira, quarto dia da semana ")]
        QUARTA_FEIRA = 4,

        /// <summary>
        /// Quinto dia da semana
        /// </summary>
        [Description("Quinta-feira, quinto dia da semana")]
        QUINTA_FEIRA = 5,
        /// <summary>
        /// Sexto dia da semana 
        /// </summary>
        [Description("Sexta-feira, sexto dia da semana")]
        CSEXTA_FEIRA = 6,
        /// <summary>
        ///Setimo e último dia da semana
        /// </summary>
        [Description("Sábado, setimo dia da semana")]
        SABADO = 7,
    }
}
