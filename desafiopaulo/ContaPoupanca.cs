using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiopaulo
{
    public class ContaPoupanca : Conta
    {
        public double TaxaDeJuros { get; private set; }

        public ContaPoupanca(string titular, double saldoInicial, double taxaDeJuros)
            : base(titular, saldoInicial)
        {
            TaxaDeJuros = taxaDeJuros;
        }

        public override void Depositar(double valor)
        {
            if (valor > 0)
            {
                double rendimento = valor * TaxaDeJuros;
                Saldo += valor + rendimento;
                Console.WriteLine($"{Titular}: Depósito de R$ {valor} realizado com sucesso. Rendimento aplicado: R$ {rendimento}");
            }
            else
            {
                Console.WriteLine($"{Titular}: Valor inválido para depósito.");
            }
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Conta Poupança - Titular: {Titular}, Saldo: R$ {Saldo}, Taxa de Juros: {TaxaDeJuros * 100}%");
        }

        internal void Depositar()
        {
            throw new NotImplementedException();
        }
    }

}
