using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalProcurator
    {
        /// <summary>
        /// Tipo de representante. Representante legal - Nome Civil completo da Pessoa Natural que represente uma entidade ou uma empresa e é nomeado em seu ato constitutivo, ou seja, no contrato social ou estatuto social.Procurador - é qualquer pessoa que represente a Pessoa Natural em algum negócio, mediante autorização escrita do mesmo.
        /// </summary>
        [Required]
        public EnumProcuratorsTypePersonal Type { get; set; }

        /// <summary>
        /// Número completo do CPF. O CPF é o Cadastro de Pessoa natural. Ele é um documento feito pela Receita Federal e serve para identificar os contribuintes. O CPF é uma numeração com 11 dígitos, que só mudam por decisão judicial. O documento é emitido pela receita federal
        /// </summary>
        [Required]
        public string CpfNumber { get; set; }

        /// <summary>
        /// Nome civil completo da pessoa natural. (Direito fundamental da pessoa, o nome civil é aquele atribuído à pessoa natural desde o registro de seu nascimento, com o qual será identificada por toda a sua vida, bem como após a sua morte)
        /// </summary>
        [Required]
        public string CivilName { get; set; }

        /// <summary>
        /// Nome social da pessoa natural, se houver. (aquele pelo qual travestis e transexuais se reconhecem, bem como são identificados por sua comunidade e em seu meio social, conforme Decreto Nº 51.180, de 14 de janeiro de 2010)
        /// </summary>
        [Required]
        public string SocialName { get; set; }
    }
}
