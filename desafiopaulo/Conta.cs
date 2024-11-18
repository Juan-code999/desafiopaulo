using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiopaulo
{
    public abstract class Conta : IConta
    {
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public Conta(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public virtual void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"{Titular}: Depósito de R$ {valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine($"{Titular}: Valor inválido para depósito.");
            }
        }

        public virtual bool Sacar(double valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"{Titular}: Saque de R$ {valor} realizado com sucesso.");
                return true;
            }
            Console.WriteLine($"{Titular}: Saque de R$ {valor} não realizado. Saldo insuficiente.");
            return false;
        }

        public virtual void Transferir(double valor, IConta contaDestino)
        {
            if (this.Sacar(valor))
            {
                contaDestino.Depositar(valor);
                Console.WriteLine($"{Titular}: Transferência de R$ {valor} realizada para {((Conta)contaDestino).Titular}.");
            }
        }

        public abstract void ExibirInformacoes();
    }

}
