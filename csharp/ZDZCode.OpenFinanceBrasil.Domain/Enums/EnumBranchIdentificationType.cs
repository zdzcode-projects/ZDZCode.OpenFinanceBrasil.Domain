using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Tipo da dependência, segundo a regulamentação do Bacen, na Resolução Nº 4072, de 26 de abril de 2012: Dependência de instituições financeiras e demais instituições, autorizadas a funcionar pelo Banco Central do Brasil, destinada à prática das atividades para as quais a instituição esteja regularmente habilitada.
    /// </summary>
    public enum EnumBranchIdentificationType
    {
        /// <summary>
        /// Agência é a dependência destinada ao atendimento aos clientes, ao público em geral e aos associados de cooperativas de crédito, no exercício de atividades da instituição, não podendo ser móvel ou transitória.
        /// </summary>
        [Description("Agência")]
        AGENCIA = 1,
        /// <summary>
        /// Posto de Atendimento é a dependência subordinada a agência ou à sede da instituição financeira, destinada ao atendimento ao público no exercício de uma ou mais de suas atividades, podendo ser fixo ou móvel. Segundo Art.15. Os Postos de Atendimento Bancário (PAB), Postos Avançados de Atendimento (PAA), Postos de Atendimento Transitórios (PAT), Postos de Compra de Ouro (PCO), Postos de Atendimento Cooperativo (PAC), Postos de Atendimento de Microcrédito (PAM), Postos Bancários de Arrecadação e Pagamento (PAP) e os Postos de Câmbio atualmente em funcionamento serão considerados PA.
        /// </summary>
        [Description("Posto de atendimento")]
        POSTO_ATENDIMENTO = 2,
        /// <summary>
        /// Posto de Atendimento Eletrônico é a dependência constituída por um ou mais terminais de autoatendimento, subordinada a agência ou à sede da instituição, destinada à prestação de serviços por meio eletrônico, podendo ser fixo ou móvel, permanente ou transitório.
        /// </summary>
        [Description("Posto de atendimento eletrônico")]
        POSTO_ATENDIMENTO_ELETRONICO = 3,
        /// <summary>
        /// Unidade Administrativa Desmembrada (UAD) segundo a Resolução 4072 , BCB, 2012, no Art. 8º "... é dependência destinada à execução de atividades administrativas da instituição, vedado o atendimento ao público".
        /// </summary>
        [Description("Unidade administrativa desmembrada")]
        UNIDADE_ADMINISTRATIVA_DESMEMBRADA = 4,
    }
}
