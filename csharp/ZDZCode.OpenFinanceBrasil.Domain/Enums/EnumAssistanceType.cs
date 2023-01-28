using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Lista padronizada de tipo de assistências ofertadas vinculadas ao produto. Por exemplo, Funeral, Bicicleta, Assistência PET – Tabela padrão a ser consolidada com retorno das empresas com a relação de assistências, permitindo um campo ‘Outros’ para assistências não contempladas na tabela padronizada.
    /// </summary>
    public enum EnumAssistanceType
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		ACOMPANHANTE_CASO_HOSPITALIZACAO_PROLONGADA = 1,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		ARQUITETO_VIRTUAL = 2,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		ASSESSORIA_FINANCEIRA = 3,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		AUTOMOVEL = 4,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		AUXILIO_NATALIDADE = 5,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		AVALIACAO_CLINICA_PREVENTIVA = 6,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		BOLSA_PROTEGIDA = 7,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		CESTA_BASICA = 8,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		CHECKUP_ODONTOLOGICO = 9,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		CLUBE_VANTAGENS_BENEFICIOS = 10,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		CONVALESCENCIA = 11,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		DECESSO = 12,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		DESCONTO_FARMACIAS_MEDICAMENTOS = 13,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		DESPESAS_FARMACEUTICAS_VIAGEM = 14,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		DIGITAL = 15,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		EDUCACIONAL = 16,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		EMPRESARIAL = 17,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		ENCANADOR = 18,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		ENTRETENIMENTO = 19,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		EQUIPAMENTOS_MEDICOS = 20,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		FIANCAS_DESPESAS_LEGAIS = 21,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		FISIOTERAPIA = 22,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		FUNERAL = 23,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		HELP_LINE = 24,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		HOSPEDAGEM_ACOMPANHANTE = 25,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		INTERRUPCAO_VIAGEM = 26,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		INVENTARIO = 27,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		MAIS_VIDA = 28,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		MAMAE_BEBE = 29,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		MEDICA_ACIDENTE_DOENCA = 30,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		MOTOCICLETA = 31,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		MULHER = 32,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		NUTRICIONISTA = 33,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		ODONTOLOGICA = 34,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		ORIENTACAO_FITNESS = 35,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		ORIENTACAO_JURIDICA = 36,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		ORIENTACAO_NUTRICIONAL = 37,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		PERSONAL_FITNESS = 38,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		ORIENTACAO_PSICOSSOCIAL_FAMILIAR = 39,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		PERDA_ROUBO_CARTAO = 40,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		PET = 41,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		PRORROGACAO_ESTADIA = 42,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		PROTECAO_DADOS = 43,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		RECOLOCACAO_PROFISSIONAL = 44,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		REDE_DESCONTO_NUTRICIONAL = 45,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		RESIDENCIAL = 46,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		RETORNO_MENORES_SEGURADO = 47,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		SAQUE_COACAO = 48,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		SAUDE_BEM_ESTAR = 49,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		SEGUNDA_OPINIAO_MEDICA = 50,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		SENIOR = 51,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		SUSTENTAVEL_DESCARTE_ECOLOGICO = 52,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		TELEMEDICINA = 53,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		VIAGEM = 54,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		VITIMA = 55,

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
		OUTROS = 56,
	}
}
