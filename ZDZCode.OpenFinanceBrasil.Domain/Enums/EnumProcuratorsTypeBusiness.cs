using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipo de representante. Representante legal - Nome Civil completo da Pessoa Natural que represente uma entidade ou uma empresa e é nomeado em seu ato constitutivo, ou seja, no contrato social ou estatuto social. Procurador - é qualquer pessoa que represente a Pessoa Natural em algum negócio, mediante autorização escrita do mesmo.
    /// </summary>
    public enum EnumProcuratorsTypeBusiness
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        REPRESENTANTE_LEGAL = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PROCURADOR = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        NAO_POSSUI = 3,
    }
}
