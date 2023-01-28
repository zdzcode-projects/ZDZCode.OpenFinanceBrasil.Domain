using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Dados de identificação na dependência.
    /// </summary>
    public class BranchIdentification
    {
        /// <summary>
        /// Tipo da dependência, segundo a regulamentação do Bacen, na Resolução Nº 4072, de 26 de abril de 2012: Dependência de instituições financeiras e demais instituições, autorizadas a funcionar pelo Banco Central do Brasil, destinada à prática das atividades para as quais a instituição esteja regularmente habilitada.
        /// </summary>
        [Display(Name = "Tipo da dependência")]
        [UIHint("Tipo da dependência, segundo a regulamentação do Bacen, na Resolução Nº 4072, de 26 de abril de 2012: Dependência de instituições financeiras e demais instituições, autorizadas a funcionar pelo Banco Central do Brasil, destinada à prática das atividades para as quais a instituição esteja regularmente habilitada.")]
        [EnumDataType(typeof(EnumBranchIdentificationType))]
        public EnumBranchIdentificationType Type { get; set; }
        /// <summary>
        /// Código identificador da dependência. Ex. '3006','3035', '1382', '2516', '2856'.
        /// </summary>
        [Display(Name = "Código identificador da dependência")]
        [Required]
        [MaxLength(10)]
        [StringLength(10)]        
        public string Code { get; set; } = string.Empty;
        /// <summary>
        /// Dígito verificador do código da dependência.
        /// </summary>
        [Display(Name = "Dígito verificador do código da dependência")]
        [Required]
        [MaxLength(5)]
        [StringLength(5)]
        public string CheckDigit { get; set; } = string.Empty;
        /// <summary>
        /// Nome da dependência, exemplos: 3006, 'SP Ponte Morumbi', 3035, 'Uberaba São Benedito', 1382, 'ALPHAVILLE-BARUERI', 2516, 'PRIME-ALPHAVILLE', 2856, 'CID.DE DEUS-U.OSASCO'
        /// </summary>
        [Display(Name = "Nome da dependência")]
        [Required]
        [MaxLength(500)]
        [StringLength(500)]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Código da agência vinculada ao Posto de Atendimento.
        /// Preencher como o código da agência vinculada ao Posto de Atendimento - se aplicável
        /// </summary>
        [Display(Name = "Código da agência vinculada ao Posto de Atendimento.")]
        [UIHint("Preencher como o código da agência vinculada ao Posto de Atendimento - se aplicável")]
        [MaxLength(20)]
        [StringLength(20)]
        public string? RelatedBranch { get; set; }

        /// <summary>
        /// Data de abertura da dependência (uma string com data conforme especificação RFC-3339. p.ex. 2014-03-19).
        /// </summary>
        [Display(Name = "Data de abertura da dependência")]
        [MaxLength(20)]
        [StringLength(20)]
        public string? OpeningDate { get; set; }
    }
}
