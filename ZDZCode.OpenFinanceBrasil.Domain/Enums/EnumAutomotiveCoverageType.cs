using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// É o conjunto dos riscos cobertos elencados na apólice. (RESOLUÇÃO CNSP Nº 341/2016). Listagem de coberturas incluídas no produto que deve observar a relação discriminada de coberturas, conforme Tabela Tipo de Cobertura
    /// </summary>
    public enum EnumAutomotiveCoverageType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ROUBO_TOTAL_OU_PARCIAL = 1,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FURTO_TOTAL_OU_PARCIAL = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ABALROAMENTO = 3,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_NECESSARIAS_SOCORRO_SALVAMENTO = 4,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_HIGIENIZACAO_VEÍCULO = 5,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_EXTRAORDINARIAS = 6,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_EXTRAORDINARIAS_MOTO = 7,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_MEDICO_HOSPITALARES = 8,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_ODONTOLOGICAS = 9,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CREDITOS_CORRIDAS_APLICATIVOS_TRANSPORTE = 10,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        COBERTURA_ADICIONAL_OPCIONAIS = 11,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_EXTRAS_INDENIZACAO_INTEGRAL = 12,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_EXTRAS_INDENIZACAO_PARCIAL = 13,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SEGURO_GARANTIDO_CASO_INDENIZACAO_INTEGRAL = 14,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        REPARO_RAPIDO_SUPERMARTELINHO = 15,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ISENCAO_FRANQUIA = 16,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESCONTO_FRANQUIA = 17,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        COBERTURA_VEICULO_REBOCADO = 18,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DANOS_CORPORAIS_RCFV = 19,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DANOS_MATERIAIS_RCFV = 20,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DANOS_MORAIS_RCFV = 21,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DANOS_ESTETICOS_RCFV = 22,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        EXTENSAO_COBERTURA_DANOS_CORPORAIS_RCFV = 23,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DANOS_CORPORAIS_RCFC = 24,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DANOS_MATERIAIS_RCFC = 25,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DANOS_MORAIS_RCFC = 26,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DANOS_ESTETICOS_RCFC = 27,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CARTA_VERDE_DANOS_CORPORAIS = 28,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CARTA_VERDE_DANOS_MATERIAIS = 29,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        APP_DMHO_PASSAGEIRO = 30,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        APP_INVALIDEZ_PERMANENTE_PASSAGEIRO = 21,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        APP_MORTE_PASSAGEIRO = 32,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        APP_INVALIDEZ_PERMANENTE_TOTAL_PARCIAL = 33,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        VIDROS = 34,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        RETROVISORES = 35,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        FAROIS = 36,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        LANTERNAS = 37,
    
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DESPESAS_LOCACAO = 38,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ROUBO_FURTO_RADIO = 39,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ROUBO_FURTO_CD = 40,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ROUBO_FURTO_KIT_GAS = 41,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ROUBO_FURTO_TACOGRAFO = 42,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        TAXIMETRO = 43,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        LUMINOSO = 44,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CARROCERIA = 45,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        EQUIPAMENTOS_ESPECIAIS_OPCIONAIS = 46,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ACESSORIOS = 47,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        BLINDAGEM = 48,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        COBERTURA_BENS_DEIXADOS_INTERIOR_VEICULO = 49,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        COBERTURA_VEICULOS_ADAPTADOS_DEFICIENTES_FISICOS = 50,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        EIXO_ADICIONAL = 51,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        EQUIPAMENTOS = 52,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        REPARO_AIR_BAG_REPOSICAO = 53,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        COBERTURA_PARA_CHOQUE = 54,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        ENVELOPAMENTO = 55,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        DIARIA_INDISPONIBILIDADE = 56,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MOTOR_TRANSMISSÃO = 57,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MOTOR_TRANSMISSAO_DIRECAO_SUSPENSAO_FREIOS = 58,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        MOTOR_TRANSMISSAO_DIRECAO_SUSPENSAO_FREIOS_SISTEMA_ELETRICO_AR_CONDICIONADO = 59,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        COMPLETA = 60,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        CONFORTO = 61,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        SIMPLES = 62,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        GARANTIA_FRANQUIA_AUTOMOVEL = 63,

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        OUTRAS_COBERTURAS_AUTO = 64,
    }
}
