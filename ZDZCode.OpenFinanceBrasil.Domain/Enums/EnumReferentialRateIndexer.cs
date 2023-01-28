using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum EnumReferentialRateIndexer
    {
        /// <summary>
        /// SEM INDEXADOR TAXA
        /// </summary>
        [Description("SEM INDEXADOR TAXA")]
        SEM_INDEXADOR_TAXA = 1,

        /// <summary>
        /// PRE FIXADO
        /// </summary>
        [Description("PRE FIXADO")]
        PRE_FIXADO = 2,

        /// <summary>
        /// POS FIXADO TR TBF
        /// </summary>
        [Description("POS FIXADO TR TBF")]
        POS_FIXADO_TR_TBF = 3,

        /// <summary>
        /// POS FIXADO TJLP
        /// </summary>
        [Description("POS FIXADO TJLP")]
        POS_FIXADO_TJLP = 4,

        /// <summary>
        /// POS FIXADO LIBOR
        /// </summary>
        [Description("POS FIXADO LIBOR")]
        POS_FIXADO_LIBOR = 5,

        /// <summary>
        /// POS FIXADO TLP
        /// </summary>
        [Description("POS FIXADO TLP")]
        POS_FIXADO_TLP = 6,

        /// <summary>
        /// OUTRAS TAXAS POS FIXADAS
        /// </summary>
        [Description("OUTRAS TAXAS POS FIXADAS")]
        REVOKEDOUTRAS_TAXAS_POS_FIXADAS = 7,

        /// <summary>
        /// FLUTUANTES CDI
        /// </summary>
        [Description("FLUTUANTES CDI")]
        FLUTUANTES_CDI = 8,

        /// <summary>
        /// FLUTUANTES SELIC
        /// </summary>
        [Description("FLUTUANTES SELIC")]
        FLUTUANTES_SELIC = 9,

        /// <summary>
        /// OUTRAS TAXAS FLUTUANTES
        /// </summary>
        [Description("OUTRAS TAXAS FLUTUANTES")]
        OUTRAS_TAXAS_FLUTUANTES = 10,


        /// <summary>
        /// INDICES PRECOS IGPM
        /// </summary>
        [Description("INDICES PRECOS IGPM")]
        INDICES_PRECOS_IGPM = 11,

        /// <summary>
        /// INDICES PRECOS IPCA
        /// </summary>
        [Description("INDICES PRECOS IPCA")]
        INDICES_PRECOS_IPCA = 12,


        /// <summary>
        /// INDICES PRECOS IPCC
        /// </summary>
        [Description("INDICES PRECOS IPCC")]
        INDICES_PRECOS_IPCC = 13,

        /// <summary>
        /// OUTROS INDICES PRECO
        /// </summary>
        [Description("OUTROS INDICES PRECO")]
        OUTROS_INDICES_PRECO = 14,


        /// <summary>
        /// CREDITO RURAL TCR PRE
        /// </summary>
        [Description("CREDITO RURAL TCR PRE")]
        CREDITO_RURAL_TCR_PRE = 15,

        /// <summary>
        /// CREDITO RURAL TCR POS
        /// </summary>
        [Description("CREDITO RURAL TCR POS")]
        CREDITO_RURAL_TCR_POS = 16,

        /// <summary>
        /// CREDITO RURAL TRFC PRE
        /// </summary>
        [Description("CREDITO RURAL TRFC PRE")]
        CREDITO_RURAL_TRFC_PRE = 17,

        /// <summary>
        /// CREDITO RURAL TRFC POS
        /// </summary>
        [Description("CREDITO RURAL TRFC POS")]
        CREDITO_RURAL_TRFC_POS = 18,

        /// <summary>
        /// OUTROS INDEXADORES
        /// </summary>
        [Description("OUTROS INDEXADORES")]
        OUTROS_INDEXADORES = 19,
    }
}
