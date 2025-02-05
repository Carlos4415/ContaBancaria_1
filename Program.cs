// Este projeto implementa uma classe que representa uma conta bancária.  
// A classe possui os seguintes atributos:  
// - Número da conta: identificador único da conta.  
// - Titular: nome do proprietário da conta.  
// - Saldo: valor disponível na conta.  
// - Senha: utilizada para autenticação em operações bancárias.
Conta conta = new Conta();
conta.titular = "Gui Lima";
conta.idConta = 1;
conta.saldo = 20.00f;
conta.senha = 1234;

Console.WriteLine("INFORMAÇÕES DA CONTA:");
Console.WriteLine($"Titular: {conta.titular}");
Console.WriteLine($"Saldo atual: {conta.saldo}");

conta.exibirInformacoes();