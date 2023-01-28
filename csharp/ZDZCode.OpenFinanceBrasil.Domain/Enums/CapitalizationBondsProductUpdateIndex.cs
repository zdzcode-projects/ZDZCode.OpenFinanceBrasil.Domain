using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Índice utilizado na atualização dos pagamentos mensais (para títulos com mais de 12 meses de vigência) (não aplicável a pagamento único).
    /// </summary>
    public enum CapitalizationBondsProductUpdateIndex
    {
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IPCA = 1,
        
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IGPM = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        INPC = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        TR = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        INDICE_REMUNERACAO_DEPOSITOS_POUPANCA = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        OUTROS = 6,

    }
}
