using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipo de representante.
    /// </summary>
    public enum EnumProcuratorsTypePersonal
    {
        /// <summary>
        /// Nome Civil completo da Pessoa Natural que represente uma entidade ou uma empresa e é nomeado em seu ato constitutivo, ou seja, no contrato social ou estatuto social.
        /// </summary>
        [Description("")]
        REPRESENTANTE_LEGAL = 1,

        /// <summary>
        /// É qualquer pessoa que represente a Pessoa Natural em algum negócio, mediante autorização escrita do mesmo.
        /// </summary>
        [Description("")]
        PROCURADOR = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        NAO_APLICA = 3,
    }
}
