using StateTest.Classes;
using System;
using System.Collections.Generic;
using System.Text;

/*Interface que irá cuidar de todas as ações entre estados.*/

namespace StateTest.Interfaces
{
    public interface Estado_Orcamento
    {
        void AplicaDescontoExtra(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
    }
}
