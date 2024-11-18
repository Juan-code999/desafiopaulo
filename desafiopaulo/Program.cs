using desafiopaulo;
class Program
{
    static void Main()
    {
        var gestao = new GestaoContas();
        
        var conta1 = new ContaCorrente("Juancharles", 1500, 100);
        
        var conta2 = new ContaPoupanca("PAULO", 2500, 1.2);
        
        gestao.AdicionarConta(conta1);
        gestao.AdicionarConta(conta2);
        gestao.ExibirContas();
        conta1.Depositar(100);
        conta2.Depositar(150);
        conta1.Sacar(1500);
        conta2.Sacar(2500);
        gestao.RealizarTransferencia("jao", "Gabriel", 500);
        gestao.ExibirContas();
    }
}