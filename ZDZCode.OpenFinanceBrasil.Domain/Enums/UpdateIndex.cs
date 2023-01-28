using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Índice utilizado na atualização do prêmio e do capital segurado, caso critério de atualização por meio de índice:
    /// </summary>
    public enum UpdateIndex
    {
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        IPCA = 1,
        
        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description(" ")]
        IGP_M = 2,

        /// <summary>
        /// Telefone móvel.
        /// </summary>
        [Description(" ")]
        INPC = 3,
    }
}
