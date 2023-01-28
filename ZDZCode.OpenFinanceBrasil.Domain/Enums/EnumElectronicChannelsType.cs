using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumElectronicChannelsType
    {
        /// <summary>
        /// Internet banking.
        /// </summary>
        [Description("Internet banking.")]
        INTERNET_BANKING= 1,

        /// <summary>
        /// Mobile banking.
        /// </summary>
        [Description("Mobile banking.")]
        MOBILE_BANKING	= 2,

        /// <summary>
        /// Chat.
        /// </summary>
        [Description("Chat.")]
        CHAT= 3,

        /// <summary>
        /// Outros
        /// </summary>
        [Description("Outros")]
        OUTROS= 4,

      
    }
}
