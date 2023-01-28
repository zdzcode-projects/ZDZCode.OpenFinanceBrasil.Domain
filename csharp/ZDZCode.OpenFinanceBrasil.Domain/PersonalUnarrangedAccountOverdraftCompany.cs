using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalUnarrangedAccountOverdraftCompany
    {
        /// <summary>
        /// Nome da Instituição, pertencente à marca, responsável pela modalidade de Adiantamento a depositante para Pessoa Natural. p.ex.'Empresa da Organização A'
        /// </summary>
        [Required]
        public string name{ get; set; }

        /// <summary>
        /// O responsável pela comercialização das modalidades de Empréstimos para Pessoas Físicas consultadas - o CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica. Deve-se ter apenas os números do CNPJ, sem máscara.
        /// </summary>
        [Required]
        public string cnpjNumber { get; set; }

        /// <summary>
        /// URL do link que conterá a lista complementar com os nomes e CNPJs agrupados sob o mesmo cnpjNumber. Os contidos nessa lista possuem as mesmas características para produtos e serviços. Endereço eletrônico de acesso ao canal. URLs são limitadas a 2048 caracteres mas, para o contexto do Sistema Financeiro aberto, será adotado a metade deste tamanho. Ex. 'https://example.com/mobile-banking'
        /// </summary>
        public string urlComplementaryList { get; set; }

        /// <summary>
        /// Lista de produtos e serviços referente adiantamento a depositante
        /// </summary>
        [Required]
        public PersonalUnarrangedAccountOverdraft personalUnarrangedAccountOverdraft { get; set; }
    }
}
