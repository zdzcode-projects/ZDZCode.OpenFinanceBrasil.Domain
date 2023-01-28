using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Indexer
    {
        /// <summary>
        /// Percentual que corresponde a mediana da taxa efetiva cobrada do cliente pela contratação do Empréstimo, no intervalo informado. p.ex. '9,8700%'. A apuração pode acontecer com até 4 casas decimais. O preenchimento deve respeitar as 4 casas decimais, mesmo que venham preenchidas com zeros (representação de porcentagem p.ex: 0.1500. Este valor representa 15%. O valor 1 representa 100%)
        /// </summary>
        [Required]
        public string Rate { get; set; }
    }
}
