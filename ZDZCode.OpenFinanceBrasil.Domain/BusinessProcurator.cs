using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BusinessProcurator
    {
        /// <summary>
        /// Tipo de representante.
        /// Representante legal - Nome Civil completo da Pessoa Natural que represente uma entidade ou uma empresa e é nomeado em seu ato constitutivo, ou seja, no contrato social ou estatuto social.
        /// Procurador - é qualquer pessoa que represente a Pessoa Natural em algum negócio, mediante autorização escrita do mesmo.
        /// </summary>
        [Required]
        public EnumProcuratorsTypeBusiness Type { get; set; }

        /// <summary>
        /// Identificação do Representante Legal ou Procurador. Número do cadastro nas Receita Federal (Preencher com CPF ou CNPJ sem formatação).
        /// </summary>
        [Required]
        public string CnpjCpfNumber { get; set; }

        /// <summary>
        /// Nome civil completo ou Razão Social.
        /// </summary>
        [Required]
        public string CivilName { get; set; }

        /// <summary>
        /// Nome social da pessoa natural, se houver. Aquele pelo qual travestis e transexuais se reconhecem, bem como são identificados por sua comunidade e em seu meio social, conforme Decreto Local.[Restrição] Preenchimento obrigatório quando o sócio for uma pessoa natural.
        /// </summary>
        [Required]
        public string SocialName { get; set; }
    }
}
