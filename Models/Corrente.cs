using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}