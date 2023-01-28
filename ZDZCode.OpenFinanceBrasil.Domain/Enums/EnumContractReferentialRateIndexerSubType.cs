using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Sub tipos de taxas referenciais ou indexadores, conforme Anexo 5: Taxa referencial ou Indexador (Indx), do Documento 3040
    /// </summary>
    public enum EnumContractReferentialRateIndexerSubType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SEM_SUB_TIPO_INDEXADOR = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PRE_FIXADO = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TR_TBF = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TJLP = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        LIBOR = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TLP = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTRAS_TAXAS_POS_FIXADAS = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CDI = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SELIC = 9,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTRAS_TAXAS_FLUTUANTES = 10,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        IGPM = 11,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        IPCA = 12,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        IPCC = 13,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS_INDICES_PRECO = 14,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TCR_PRE = 15,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TCR_POS = 16,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TRFC_PRE = 17,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TRFC_POS = 18,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS_INDEXADORES = 19,
    }
}
