using StateTest.Classes.Estados;
using StateTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

/* Orcamento contém um EstadoAtual e permite a aplicação de um desconto e também a alteração de estado 
 * apenas acessando as classes que implementam a interface Estado_Orcamento.*/

namespace StateTest.Classes
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public bool Desconto { get; set; }
        public Estado_Orcamento EstadoAtual { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.EstadoAtual = new EmAprovacao();
            this.Desconto = false;
        }

        // Apenas delega para cada classe de estado aplicar a regra de desconto.
        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        //Apenas delega para cada classe de estado realizar a transição.
        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        //Apenas delega para cada classe de estado realizar a transição.
        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        //Apenas delega para cada classe de estado realizar a transição.
        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
