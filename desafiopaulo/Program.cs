using desafiopaulo;
{

    var conta1 = new ContaCorrente("Breno", 500, 300);
    var conta2 = new ContaPoupanca("Eduarda", 1000, 0.05);
    var conta3 = new ContaCorrente("Gabriel", 800, 500);

    var gestao = new GestaoContas();

 

    gestao.AdicionarConta(conta1);
    gestao.AdicionarConta(conta2);
    gestao.AdicionarConta(conta3);

    Console.WriteLine("\n--- Contas cadastradas ---");
    gestao.ExibirContas();

    Console.WriteLine("\n--- Realizando depósitos ---");
    conta1.Depositar(200);
    conta2.Depositar(300);

    Console.WriteLine("\n--- Realizando saques ---");
    conta1.Sacar(100);
    conta2.Sacar(500);

    Console.WriteLine("\n--- Realizando transferências ---");
    conta1.Transferir(200, conta3);
    conta2.Transferir(100, conta1);

    Console.WriteLine("\n--- Aplicando juros na conta poupança ---");
    if (conta2 is ContaPoupanca poupanca)
    {
        poupanca.Depositar();
    }

    Console.WriteLine("\n--- Situação final das contas ---");
    gestao.ExibirContas();
}
