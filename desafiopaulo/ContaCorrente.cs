using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiopaulo
{
    public class ContaCorrente : Conta
    {
        public double LimiteDeCredito { get; private set; }

        public ContaCorrente(string titular, double saldoInicial, double limiteDeCredito)
            : base(titular, saldoInicial)
        {
            LimiteDeCredito = limiteDeCredito;
        }

        public override bool Sacar(double valor)
        {
            if (valor > 0 && (Saldo - valor) >= -LimiteDeCredito)
            {
                Saldo -= valor;
                Console.WriteLine($"{Titular}: Saque de R$ {valor} realizado com sucesso (Saldo + Crédito disponível).");
                return true;
            }
            Console.WriteLine($"{Titular}: Saque de R$ {valor} não realizado. Limite excedido.");
            return false;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Conta Corrente - Titular: {Titular}, Saldo: R$ {Saldo}, Limite de Crédito: R$ {LimiteDeCredito}");
        }
    }

}
