using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipo do documento informado.
    /// </summary>
    public enum EnumPartiesParticipationDocumentType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CPF = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PASSAPORTE = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTRO_DOCUMENTO_VIAGEM = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CNPJ = 4,
    }
}
