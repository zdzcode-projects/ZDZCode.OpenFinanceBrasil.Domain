using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumOpeningClosingChannels
    {
        /// <summary>
        /// Dependências próprias.
        /// </summary>
        [Description("Dependências próprias.")]
        DEPENDENCIAS_PROPRIAS = 1,

        /// <summary>
        /// Correspondentes bancários.
        /// </summary>
        [Description("Correspondentes bancários")]
        CORRESPONDENTES_BANCARIOS = 2,

        /// <summary>
        /// Internet banking.
        /// </summary>
        [Description("Internet banking.")]
        INTERNET_BANKING = 3,

        /// <summary>
        ///Mobile banking.
        /// </summary>
        [Description("Mobile banking.")]
        MOBILE_BANKING = 4,

        /// <summary>
        /// Central telefônica.
        /// </summary>
        [Description("Central telefônica.")]
        CENTRAL_TELEFONICA	 = 5,

        /// <summary>
        /// Chat.
        /// </summary>
        [Description("Chat.")]
        CHAT = 6,

        /// <summary>
        /// Outros (p.ex. website/apps de terceiros)
        /// </summary>
        [Description("Outros (p.ex. website/apps de terceiros)")]
        OUTROS = 7,
    }
}
