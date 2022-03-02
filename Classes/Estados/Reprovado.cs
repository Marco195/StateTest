using StateTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateTest.Classes.Estados
{
    class Reprovado : Estado_Orcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Um orçamento no estado REPROVADO não pode receber um desconto.");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar um orçamento REPROVADO.");

        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O orçamento atual já está no estado REPROVADO.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
