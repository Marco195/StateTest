using StateTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateTest.Classes.Estados
{
    class Finalizado : Estado_Orcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Um orçamento no estado FINALIZADO não pode receber um desconto.");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar um orçamento FINALIZADO.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar um orçamento FINALIZADO.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("O orçamento atual já está no estado FINALIZADO.");
        }
    }
}
