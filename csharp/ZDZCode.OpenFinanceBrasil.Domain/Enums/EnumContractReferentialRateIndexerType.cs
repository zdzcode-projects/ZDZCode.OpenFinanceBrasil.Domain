using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipos de taxas referenciais ou indexadores, conforme Anexo 5: Taxa referencial ou Indexador (Indx), do Documento 3040
    /// </summary>
    public enum EnumContractReferentialRateIndexerType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SEM_TIPO_INDEXADOR = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PRE_FIXADO = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        POS_FIXADO = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FLUTUANTES = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        INDICES_PRECOS = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CREDITO_RURAL = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS_INDEXADORES = 7,
    }
}
