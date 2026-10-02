//Cadastro do cliente. 


string nome = "";
string nickname = "";
int cliente = 0;
double saldo = 0;
string plataforma = "";

Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();
Console.WriteLine("Digite o seu nickname:");
nickname = Console.ReadLine();
Console.WriteLine("Digite o ano que você virou cliente");
cliente = int.Parse(Console.ReadLine());

Console.WriteLine("Digitei o seu saldo: ");
saldo = double.Parse(Console.ReadLine());

Console.WriteLine("Qual plataforma você usa?");
plataforma = Console.ReadLine();

Console.WriteLine("=== Ficha Cliente ===");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Nickname: {nickname}");
Console.WriteLine($"Saldo: {saldo}");
Console.WriteLine($"Plataforma: {plataforma}");
Console.WriteLine($"Que ano virou cliente: {cliente}\n");

// Nível 2

Console.WriteLine("Qual o nome do jogo?");
string jogo = Console.ReadLine();

Console.WriteLine("Qual a Plataforma desse jogo?");
string plataforma1 = Console.ReadLine();

Console.WriteLine("Qual o preço desse jogo?\n");
double preço = double.Parse(Console.ReadLine());

double precorestante = saldo - preço;

if (plataforma1 == plataforma && saldo >= preço)
{
    Console.WriteLine($"Preço do jogo: {preço}");
    Console.WriteLine($"Nome do jogo: {jogo}");
    Console.WriteLine($"Plataforma do jogo: {plataforma}");
    Console.WriteLine($"Saldo que vai sobrar: {precorestante}");
}
else
{
    Console.WriteLine("Não pode comprar");

}


// Nível 3

//using System.Net;
//using System.Threading.Channels;

Console.WriteLine("Quantos jogos você tem?");
int quantidadeNum = int.Parse(Console.ReadLine());

string[] quantidadeJogos = new string[quantidadeNum];

if (quantidadeNum != 0)
{
    for (int i = 0; i < quantidadeNum; i++)
    {
        Console.WriteLine("Digite o nome de um dos seus jogos: ");
        quantidadeJogos[i] = Console.ReadLine();

    }

    Console.WriteLine("=== Biblioteca de Jogos ===");

    for (int i = 0; i < quantidadeJogos.Length; i++)
    {

        Console.WriteLine($"{i + 1} - {quantidadeJogos[i]}");

    }
}

// Nível 4

Console.WriteLine("Qual jogo você quer procurar na sua biblioteca? (Procure por nome)");
string jogoProcurar = Console.ReadLine();

bool achado = false;

for (int i = 0; i <= quantidadeJogos.Length; i++)
{
    try
    {
        if (jogoProcurar == quantidadeJogos[i])
        {
            Console.WriteLine("Jogo encontrado!");
            i = quantidadeJogos.Length;

            achado = true;

        break;

        }

    }
    catch
    {
        Console.WriteLine("Jogo não encontrado");
    }
}

// Nível 5

double somaTotal = 0;
double[] custoJogos = new double[quantidadeJogos.Length];
for (int i = 0; i < quantidadeJogos.Length; i++)
{
    Console.WriteLine($"Quanto você pagou no {quantidadeJogos[i]}?");
    custoJogos[i] = double.Parse(Console.ReadLine());
    somaTotal = somaTotal + custoJogos[i];
}

double mediaCompra = somaTotal / quantidadeJogos.Length;
string clienteVIP = "";
if (somaTotal >= 500)
{
    clienteVIP = "Cliente VIP!";
}
else
{
    clienteVIP = "Cliente Comum, faltam " + (500 - somaTotal) + " para se tornar um cliente VIP";
}

Console.WriteLine("Total Gasto: " + somaTotal);
Console.WriteLine("Média por compra: " + mediaCompra);
Console.WriteLine("Status: " + clienteVIP);

// Nível 6

double maiorValor = 0;
string nomeMaior = "";

for (int v = 0; v <  custoJogos.Length ; v++)
{
    if (custoJogos[v] > maiorValor)
    {
        maiorValor = custoJogos[v];
        nomeMaior = quantidadeJogos[v];
    }
}

Console.WriteLine("Jogo mais caro: " + nomeMaior + " (R$" + maiorValor + ")");

// Nível 7

int[] horas = new int[quantidadeJogos.Length];
double horasTotais = 0;
double horaMaior = 0;
string jogoEncostado = "";

for (int i = 0; i < quantidadeJogos.Length; i++)
{
    Console.WriteLine("Quantas horas você jogou " + quantidadeJogos[i] + " ?");
    horas[i] = int.Parse(Console.ReadLine());
    horasTotais = horasTotais + horas[i];
    
    if (horas[i] > horaMaior)
    {
        horaMaior = horas[i];
    }

    if (horas[i] == 0)
    {
        jogoEncostado = quantidadeJogos[i];
    }
}
Console.WriteLine("----------");
Console.WriteLine($"Total de horas jogadas: {horasTotais}");
Console.WriteLine($"Mais jogado: {horaMaior}");
Console.WriteLine($"Jogos encostado: {jogoEncostado}");

// Nível 8

Console.WriteLine("Qual jogo você quer comprar?");
string jogoComprar = Console.ReadLine();

Console.WriteLine("Qual a plataforma desse jogo?");
string plataformaComprar = Console.ReadLine();

Console.WriteLine("Qual o preço desse jogo?");
double precoComprar = double.Parse(Console.ReadLine());

bool podeComprar = false;

for (int i = 0; i < quantidadeJogos.Length; i++)
{
    if (jogoComprar == quantidadeJogos[i])
    {
        Console.WriteLine("Compra Bloqueada, Jogo já adquirido");
        break;
    }
    else if (plataforma != plataformaComprar)
    {
        Console.WriteLine("Compra Bloqueada, Plataforma diferente da atual");
        break;
    }
    else if (saldo > precoComprar)
    {
        double precoFaltante = precoComprar - saldo;
        Console.WriteLine("Compra Bloqueada, saldo insuficiente, faltam" + precoFaltante);
        break;
    }
    else
    {
        Console.WriteLine("Jogo adicionado na biblioteca!");
        podeComprar = true;
    }
}

if (podeComprar)
{
    string[] novosJogos = new string[quantidadeJogos.Length + 1];
    double[] novosValores = new double[custoJogos.Length + 1];
    int[] novasHoras = new int[horas.Length + 1];

    for (int i = 0; i < quantidadeJogos.Length; i++)
    {
        novosJogos[i] = quantidadeJogos[i];
        novosValores[i] = custoJogos[i];
        novasHoras[i] = horas[i];
    }
}








// Nível 9