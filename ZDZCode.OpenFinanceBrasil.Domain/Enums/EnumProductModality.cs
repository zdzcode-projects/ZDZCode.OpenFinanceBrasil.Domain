using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Identificação do Tipo de telefone da dependência. p.ex.FIXO, MOVEL
    /// </summary>
    public enum EnumProductModality
    {
        /// <summary>
        /// Funeral
        /// </summary>
        [Description("Funeral")]
        FUNERAL = 1,

        /// <summary>
        /// Prestamista (exceto Habitacional e Rural)
        /// </summary>
        [Description("Prestamista (exceto Habitacional e Rural)")]
        PRESTAMISTA = 2,

        /// <summary>
        /// Viagem
        /// </summary>
        [Description("Viagem")]
        VIAGEM = 3,

        /// <summary>
        /// Educacional
        /// </summary>
        [Description("Educacional")]
        EDUCACIONAL = 4,

        /// <summary>
        /// Dotal (Misto e Puro)
        /// </summary>
        [Description("Dotal (Misto e Puro)")]
        DOTAL = 5,

        /// <summary>
        /// Acidentes Pessoais
        /// </summary>
        [Description("Acidentes Pessoais")]
        ACIDENTES_PESSOAIS = 6,

        /// <summary>
        /// Vida
        /// </summary>
        [Description("Vida")]
        VIDA = 7,

        /// <summary>
        /// Perda do Certificado de Habilitação de Voo – PCHV
        /// </summary>
        [Description("Perda do Certificado de Habilitação de Voo – PCHV")]
        PERDA_CERTIFICADO_HABILITACAO_VOO = 8,

        /// <summary>
        /// Doenças Graves ou Doença Terminal
        /// </summary>
        [Description("Doenças Graves ou Doença Terminal")]
        DOENCAS_GRAVES_DOENCA_TERMINAL = 9,

        /// <summary>
        /// Desemprego/ Perda de Renda
        /// </summary>
        [Description("Desemprego/ Perda de Renda")]
        DESEMPREGO_PERDA_RENDA = 10,

        /// <summary>
        /// Eventos Aleatórios
        /// </summary>
        [Description("Eventos Aleatórios")]
        EVENTOS_ALEATORIOS = 11,

        /// <summary>
        /// Pecúlio
        /// </summary>
        [Description("Pecúlio")]
        PECULIO = 12,

        /// <summary>
        /// Pensão prazo certo
        /// </summary>
        [Description("Pensão prazo certo")]
        PENSAO_PRAZO_CERTO = 13,

        /// <summary>
        /// Pensão menores 21 anos
        /// </summary>
        [Description("Pensão menores 21 anos")]
        PENSAO_MENORES_21 = 14,

        /// <summary>
        /// Pensão menores 24 anos
        /// </summary>
        [Description("Pensão menores 24 anos")]
        PENSAO_MENORES_24 = 15,

        /// <summary>
        /// Pensão cônjuge vitalícia
        /// </summary>
        [Description("Pensão cônjuge vitalícia")]
        PENSAO_CONJUGE_VITALICIA = 16,

        /// <summary>
        /// Pensão cônjuge temporária
        /// </summary>
        [Description("Pensão cônjuge temporária")]
        PENSAO_CONJUGE_TEMPORARIA = 17,
    }
}
