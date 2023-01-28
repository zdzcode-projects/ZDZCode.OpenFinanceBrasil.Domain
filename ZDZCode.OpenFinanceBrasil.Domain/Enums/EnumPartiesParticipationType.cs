using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Indica o perfil de atuação na empresa
    /// </summary>
    public enum EnumPartiesParticipationType
    {
        /// <summary>
        /// Sócio não tem qualquer envolvimento nas atividades administrativas da sociedade.
        /// </summary>
        [Description("")]
        SOCIO = 1,

        /// <summary>
        /// O administrador é o responsável por desempenhar todas as funções administrativas da empresa. É ele quem conduz o dia a dia do negócio, assinando documentos, respondendo legalmente pela sociedade, realizando empréstimos e outras ações gerenciais. Apesar de estar na linha de frente da empresa, ele é denominado sócio por também possuir sua parcela de participação no Capital Social.
        /// </summary>
        [Description("")]
        ADMINISTRADOR = 2,
    }
}
