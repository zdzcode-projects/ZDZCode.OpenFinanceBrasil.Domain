using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumStatusCode
    {
        /// <summary>
        /// A implementação é totalmente funcional
        /// </summary>
        [Description("A implementação é totalmente funcional")]
        OK = 1,

        /// <summary>
        /// Um ou mais endpoints estão indisponíveis
        /// </summary>
        [Description("Um ou mais endpoints estão indisponíveis")]
        PARTIAL_FAILURE = 2,

        /// <summary>
        /// A implementação completa está indisponível
        /// </summary>
        [Description("A implementação completa está indisponível")]
        UNAVAILABLE = 3,

        /// <summary>
        /// Uma interrupção anunciada está em vigor
        /// </summary>
        [Description("Uma interrupção anunciada está em vigor")]
        SCHEDULED_OUTAGE = 4,

        

    }
}
