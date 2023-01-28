using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Índice utilizado como referência para a correção da rentabilidade e/ou rendimentos do ativo (p.ex. CDI).
    /// </summary>
    public enum EnumInvestmentsFixedIncomeBankIndexer
    {
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        CDI = 1,
        
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        DI = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        TR = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IPCA = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IGP_M = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IGP_DI = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        INPC = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        BCP = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        TLC = 9,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        SELIC = 10,

        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        OUTROS = 11,
    }
}
