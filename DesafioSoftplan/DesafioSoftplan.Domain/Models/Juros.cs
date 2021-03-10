using DesafioSoftplan.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioSoftplan.Domain.Models
{
    public class Juros
    {
        public double ConsultaTavaJuros()
        {
            return 0.01;
        }
        public double calculaJuros (CalculaJurosVM calculaJurosVM,double Taxajuros)
        {
            var juros = Math.Pow(calculaJurosVM.ValorInical * (1 + Taxajuros), calculaJurosVM.Meses);
            return juros;
        }
    }
}
