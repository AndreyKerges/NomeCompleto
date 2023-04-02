//declarações das variáveis do tipo string
string nome, sobrenome;

//Exibe a mensagem "Digite seu Primeiro Nome:" no console
Console.WriteLine("Digite seu Primeiro Nome: ");
//Lê a entrada do usuário do console e atribui o valor à variável nome.
nome = Console.ReadLine()!;


Console.WriteLine("Digite seu Sobrenome: ");
sobrenome = Console.ReadLine()!;

//linha em branco, quebra de linha
Console.WriteLine();

//Exibe o nome completo do usuário no console, utilizando as variáveis nome e sobrenome.
Console.WriteLine($"Nome Completo: {nome} {sobrenome}");

//Exibe a mensagem "Seu nome de catálogo é: " no console, sem quebrar a linha
Console.Write("Seu nome de catálogo é: ");
//Exibe o nome completo do usuário em caixa alta e com o sobrenome antes do nome, no formato de "sobrenome, nome"
Console.Write($"{sobrenome.ToUpper()} {nome}");
