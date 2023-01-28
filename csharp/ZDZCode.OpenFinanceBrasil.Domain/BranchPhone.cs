using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Telefones da Dependência.
    /// </summary>
    public class BranchPhone
    {
        /// <summary>
        /// Identificação do Tipo de telefone da dependência. p.ex.FIXO, MOVEL
        /// </summary>
        /// <value>
        /// FIXO
        /// </value>
        /// <value>
        /// MOVEL
        /// </value>
        [Display(Name = "Tipo de telefone")]
        [EnumDataType(typeof(EnumBranchPhoneType))]
        public EnumBranchPhoneType Type { get; set; }
        /// <summary>
        /// Número de DDI (Discagem Direta Internacional) para telefone de acesso ao Canal - se houver. p.ex. '55'
        /// </summary>
        [Display(Name = "DDI")]
        [MaxLength(2)]
        [StringLength(2)]
        [MinLength(2)]
        public string? CountryCallingCode { get; set; }
        /// <summary>
        /// Número de DDD (Discagem Direta à Distância) do telefone da dependência - se houver. p.ex. '19'
        /// </summary>
        [Display(Name = "DDD")]
        [MaxLength(2)]
        [StringLength(2)]
        [MinLength(2)]
        public string? AreaCode { get; set; }
        /// <summary>
        /// Número de telefone da dependência - se houver
        /// </summary>
        [Display(Name = "Telefone")]
        [MaxLength(10)]
        [StringLength(10)]
        public string? Number { get; set; }
    }
}
