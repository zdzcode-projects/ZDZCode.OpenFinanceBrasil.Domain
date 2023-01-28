using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Denominação/Identificação do sub tipo da garantia que avaliza a Modalidade da Operação de Crédito contratada (Doc 3040, Anexo 12).
    /// </summary>
    public enum EnumWarrantySubType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ACOES_DEBENTURES = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        APLICACOES_FINANCEIRAS_RENDA_FIXA = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        APLICACOES_FINANCEIRAS_RENDA_VARIAVEL = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        APOLICES_CREDITO_EXPORTACAO = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CCR_CONVENIO_CREDITOS_RECIPROCOS = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CHEQUES = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CIVIL = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DIREITOS_SOBRE_ALUGUEIS = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DEPOSITOS_A_VISTA_A_PRAZO_POUPANCA_OURO_TITULOS_PUBLICOS_FEDERAIS_ART_36 = 9,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DEPOSITO_TITULOS_EMITIDOS_ENTIDADES_ART_23 = 10,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DUPLICATAS = 11,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        EMD_ENTIDADES_MULTILATERAIS_DESENVOLVIMENTO_ART_37 = 12,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        EQUIPAMENTOS = 13,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ESTADUAL_OU_DISTRITAL = 14,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FATURA_CARTAO_CREDITO = 15,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FEDERAL = 16,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FCVS_FUNDO_COMPENSACAO_VARIACOES_SALARIAIS = 17,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FGI_FUNDO_GARANTIDOR_INVESTIMENTOS = 18,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FGPC_FUNDO_GARANTIA_PROMOCAO_COMPETIT = 19,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FGTS_FUNDO_GARANTIA_TEMPO_SERVICO = 20,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FUNDO_GARANTIDOR_AVAL = 21,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        GARANTIA_PRESTADA_FGPC_LEI_9531_ART_37 = 22,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        GARANTIA_PRESTADA_FUNDOS_QUAISQUER_OUTROS_MECANISMOS_COBERTURA_RISCO_CREDITO_ART_37 = 23,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        GARANTIA_PRESTADA_TESOURO_NACIONAL_OU_BACEN_ART_37_BENS_DIREITOS_INTEGRANTES_PATRIMONIO_AFETACAO = 24,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        IMOVEIS = 25,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        IMOVEIS_RESIDENCIAIS = 26,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MITIGADORAS = 27,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MUNICIPAL = 28,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        NAO_MITIGADORAS = 29,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        NOTAS_PROMISSORIAS_OUTROS_DIREITOS_CREDITO = 30,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTRAS = 31,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS = 32,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS_BENS = 33,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS_GRAUS = 34,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS_IMOVEIS = 35,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTROS_SEGUROS_ASSEMELHADOS = 36,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PESSOA_FISICA = 37,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PESSOA_FISICA_EXTERIOR = 38,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PESSOA_JURIDICA = 39,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PESSOA_JURIDICA_EXTERIOR = 40,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PRIMEIRO_GRAU_BENS_DIREITOS_INTEGRANTES_PATRIMONIO_AFETACAO = 41,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PRIMEIRO_GRAU_IMOVEIS_RESIDENCIAIS = 42,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PRIMEIRO_GRAU_OUTROS = 43,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PRODUTOS_AGROPECUARIOS_COM_WARRANT = 44,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        PRODUTOS_AGROPECUARIOS_SEM_WARRANT = 45,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SBCE_SOCIEDADE_BRASILEIRA_CREDITO_EXPORTAÇÃO = 46,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SEGURO_RURAL = 47,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TRIBUTOS_RECEITAS_ORCAMENTARIAS = 48,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        VEICULOS = 49,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        VEICULOS_AUTOMOTORES = 50,
    }
}
