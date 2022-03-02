using StateTest.Classes.Estados;
using StateTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

/* Orcamento contém um EstadoAtual e permite a aplicação de um desconto e também a alteração de estado apenas acessando a interface de Estado_Orcamento.*/

namespace StateTest.Classes
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public Estado_Orcamento EstadoAtual { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
