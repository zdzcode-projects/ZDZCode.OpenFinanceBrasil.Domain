using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Customer
    {
        /// <summary>
        /// Percentual dos clientes de cada faixa relativa ao serviço ofertado, para pessoa natural informado no período, conforme Res nº32 BCB, 2020. p.ex. '0.1500' (representa uma porcentagem Ex: 0.15 (O valor ao lado representa 15%. O valor '1 'representa 100%) A apuração pode acontecer com até 4 casas decimais. O preenchimento deve respeitar as 4 casas decimais, mesmo que venham preenchidas com zeros (representação de porcentagem p.ex: 0.1500. Este valor representa 15%%. O valor 1 representa 100%)
        /// </summary>
        [Required]
        public string Rate { get; set; }
    }
}
