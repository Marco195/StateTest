using StateTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateTest.Classes.Estados
{
    class Aprovado : Estado_Orcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Um orçamento já está no estado APROVADO.");

        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar um orçamento já aprovado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
