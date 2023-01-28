using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumPersonalOtherDocumentType
    {

        // Relação dos Códigos dos demais documentos pessoa natural.

        /// <summary>
        /// Carteira nascional de Habilitação 
        /// </summary>
        [Description("CNH")]
        CNH = 1,

        /// <summary>
        /// RG : documento nacional de identificação civil no Brasil
        /// </summary>
        [Description("RG")]
        RG = 2,

        /// <summary>
        /// número de identificação fiscal
        /// </summary>
        [Description("NIF")]
        NIF = 3,

        /// <summary>
        /// registro nacional de estrangeiros
        /// </summary>
        [Description("RNE")]
        RNE = 4,

        /// <summary>
        /// Outros
        /// </summary>
        [Description("OUTROS")]
        OUTROS = 5,

        /// <summary>
        /// outros documentos
        /// </summary>
        [Description("SEM OUTROS DOCUMENTOS")]
        SEM_OUTROS_DOCUMENTOS = 6,
    }
}
