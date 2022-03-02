using StateTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateTest.Classes.Estados
{
    class EmAprovacao : Estado_Orcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Um orçamento em aprovação não pode ir para FINALIZADO diretamente.");
        }
    }
}
