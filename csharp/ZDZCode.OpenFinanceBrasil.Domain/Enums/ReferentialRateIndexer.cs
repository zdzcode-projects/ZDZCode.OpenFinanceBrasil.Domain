using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public enum ReferentialRateIndexer
    {
        /// <summary>
        /// SEM INDEXADOR TAXA
        /// </summary>
        SEM_INDEXADOR_TAXA = 1,

        /// <summary>
        /// PRE FIXADO
        /// </summary>
        PRE_FIXADO = 2,

        /// <summary>
        /// POS FIXADO TR TBF
        /// </summary>
        POS_FIXADO_TR_TBF = 3,

        /// <summary>
        /// POS FIXADO TJLP
        /// </summary>
        POS_FIXADO_TJLP = 4,

        /// <summary>
        /// POS FIXADO LIBOR
        /// </summary>
        POS_FIXADO_LIBOR = 5,

        /// <summary>
        /// POS FIXADO TLP
        /// </summary>
        POS_FIXADO_TLP = 6,

        /// <summary>
        /// OUTRAS TAXAS POS FIXADAS
        /// </summary>
        OUTRAS_TAXAS_POS_FIXADAS = 7,

        /// <summary>
        /// FLUTUANTES CDI
        /// </summary>
        FLUTUANTES_CDI = 8,

        /// <summary>
        /// FLUTUANTES SELIC
        /// </summary>
        FLUTUANTES_SELIC = 9,

        /// <summary>
        /// OUTRAS TAXAS FLUTUANTES
        /// </summary>
        OUTRAS_TAXAS_FLUTUANTES = 10,

        /// <summary>
        /// INDICES PRECOS IGPM
        /// </summary>
        INDICES_PRECOS_IGPM = 11,

        /// <summary>
        /// INDICES PRECOS IPCA
        /// </summary>
        INDICES_PRECOS_IPCA = 12,

        /// <summary>
        /// INDICES PRECOS IPCC
        /// </summary>
        INDICES_PRECOS_IPCC = 13,

        /// <summary>
        /// OUTROS INDICES PRECO
        /// </summary>
        OUTROS_INDICES_PRECO = 14,

        /// <summary>
        /// CREDITO RURAL TCR PRE
        /// </summary>
        CREDITO_RURAL_TCR_PRE = 15,

        /// <summary>
        /// CREDITO RURAL TCR POS
        /// </summary>
        CREDITO_RURAL_TCR_POS = 16,

        /// <summary>
        /// CREDITO RURAL TRFC PRE
        /// </summary>
        CREDITO_RURAL_TRFC_PRE = 17,

        /// <summary>
        /// CREDITO RURAL TRFC POS
        /// </summary>
        CREDITO_RURAL_TRFC_POS = 18,

        /// <summary>
        /// OUTROS INDEXADORES
        /// </summary>
        OUTROS_INDEXADORES = 19,
    }
}
