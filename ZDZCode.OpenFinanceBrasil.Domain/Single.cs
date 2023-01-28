using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Single
    {
        /// <summary>
        /// Define a data alvo da liquidação do pagamento. O fuso horário de Brasilia deve ser utilizado para criação e racionalização sobre os dados deste campo.
        /// OBS:Esse campo deverá sempre ser no mínimo D+1 corrido, ou seja, a data imediatamente posterior em relação a data do consentimento considerando o fuso horário de Brasília e deverá ser no máximo um ano corrido a partir da data do consentimento considerando o fuso horário de Brasília.
        /// </summary>
        [Required]
        public string Date { get; set; }
    }
}
