using byteBank;
using byteBank.Titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

//ContaCorrente conta1 = new ContaCorrente();

//conta1.titular = "Jéssica";
//conta1.conta = "10123-X";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agencia central";
//conta1.saldo = 200;

//ContaCorrente conta2 = new ContaCorrente();

//conta2.titular = "Jéssica";
//conta2.conta = "10123-X";
//conta2.numero_agencia = 23;
//conta2.nome_agencia = "Agencia central";
//conta2.saldo = 100;

//Console.WriteLine(conta1 == conta2);

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
//Console.WriteLine("Nome Agencia: " + conta1.nome_agencia);
//Console.WriteLine("Saldo: " + conta1.saldo);



// AULA TIPO DE VALOR
//double saldo = 100;
//double saldo2 = 100;
//double saldo3 = conta1.saldo;

//Console.WriteLine(saldo == conta1.saldo);
//Console.WriteLine(saldo == saldo3);

//Aula metodos
//Console.WriteLine("Saldo Jéssica pré-saque: " + conta2.saldo);

//bool saque = conta2.Sacar(50);

//Console.WriteLine("Saque realizado? " + saque);

//Console.WriteLine("Saldo Jéssica pos-saque: " + conta2.saldo);

//conta2.Depositar(60);

//Console.WriteLine("Saldo Jéssica pos-deposito: " + conta2.saldo);

//Console.WriteLine("Saldo conta1 pre-deposito: " + conta1.saldo);
//Console.WriteLine("Saldo conta2 pos-deposito: " + conta2.saldo);

//bool transferencia = conta1.Transferir(50, conta2);

//Console.WriteLine("--------------------------------------------");
//Console.WriteLine("|            Transferir R$50,00            |");
//Console.WriteLine("|            "+ transferencia +"                          |");
//Console.WriteLine("--------------------------------------------");

//Console.WriteLine("Saldo conta1 pos-deposito: " + conta1.saldo);
//Console.WriteLine("Saldo conta2 pos-deposito: " + conta2.saldo);

//Cliente cliente = new Cliente();
//cliente.nome = "Jéssica";
//cliente.cpf = "103025454";
//cliente.profissao = "QA";

//Cliente sarah = new Cliente();

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = new Cliente();
//conta3.titular.nome = "Jéssica";
//conta3.titular.profissao = "QA";
//conta3.titular.cpf = "1234"; 

//conta3.conta = "14545454";
//conta3.numero_agencia = 20;
//conta3.nome_agencia = "teste";

//Console.WriteLine(conta3);
//Cliente jessica = new Cliente();
//jessica.Nome = "Jésisca";

//ContaCorrente conta4 = new ContaCorrente(235,"12131");
//conta4.Saldo = 100;
//conta4.Titular = jessica;


//Console.WriteLine("Saldo: " +conta4.Saldo);

ContaCorrente conta5 = new ContaCorrente(235,"12131");

ContaCorrente conta6 = new ContaCorrente(236,"12132");

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();