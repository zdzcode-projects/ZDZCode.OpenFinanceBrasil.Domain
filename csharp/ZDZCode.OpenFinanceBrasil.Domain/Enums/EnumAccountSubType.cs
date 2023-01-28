using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Subtipo de conta.
    /// </summary>
    public enum EnumAccountSubType
    {
        /// <summary>
        /// Possui um único titular.
        /// </summary>
        [Description("Possui um único titular")]
        INDIVIDUAL = 1,

        /// <summary>
        /// Onde as movimentações financeiras só podem serem realizadas mediante autorização de TODOS os correntistas da conta.
        /// </summary>
        [Description("Onde as movimentações financeiras só podem serem realizadas mediante autorização de TODOS os correntistas da conta")]
        CONJUNTA_SIMPLES = 2,

        /// <summary>
        ///  É a modalidade cujos titulares podem realizar movimentações de forma isolada, isto é, sem que seja necessária a autorização dos demais titulares.
        /// </summary>
        [Description("É a modalidade cujos titulares podem realizar movimentações de forma isolada, isto é, sem que seja necessária a autorização dos demais titulares")]
        CONJUNTA_SOLIDARIA = 2,


    }
}
