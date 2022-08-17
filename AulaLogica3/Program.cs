/*int n1;
int n2;
int soma;

Console.Write("Entre com o primeiro numero: ");
n1 = int.Parse(Console.ReadLine());

Console.Write("Entre com o segundo numero: ");
n2 = int.Parse(Console.ReadLine());

soma = n1 + n2;

Console.WriteLine($"O resultado da soma é: {soma}");
*/
/*
string nome;
string endereco;
string cpf; 

Console.Write("Entre com o nome: ");
nome = Console.ReadLine();

Console.Write("Entre com o endereço: ");
endereco = Console.ReadLine();

Console.Write("Entre com o cpf");
cpf = Console.ReadLine();

Console.WriteLine($"{nome} mora no endereço {endereco}" +
    $" e possui o cpf de numero: {cpf}");
*/

/*
double nota1;
double nota2;
double nota3;
double nota4;
double media;

Console.WriteLine("Entre com a primeira nota");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com a segunda nota");
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com a terceira nota");
nota3 = double.Parse(Console.ReadLine());

media = nota1 + nota2 + nota3;

Console.WriteLine("Entre com a quarta nota");
nota4 = double.Parse(Console.ReadLine());

media = (media + nota4) / 4;

Console.WriteLine($"A media das notas é: {media}");
*/

/*
double F;
double C;

Console.WriteLine("Entre com a temperatura em fahrenheit: ");
F = double.Parse(Console.ReadLine());

C = (F - 32) * 5 / 9;
Console.WriteLine($"A temperatura em celsius é: {C}");
*/

/*
double produto;
double valorDesconto;
double desconto;

Console.Write("Entre com o valor do produto: ");
produto = double.Parse(Console.ReadLine());

Console.Write("Entre com o valor da procentagem do desconto: ");
valorDesconto = double.Parse(Console.ReadLine());

desconto = produto - (produto * (valorDesconto / 100));

Console.WriteLine($"O produto com {valorDesconto}% de desconto fica: {desconto}");

//thiago barbosa, renor
*/
double valorProduto;
double valorDesconto;

Console.WriteLine("Entre com o valor do produto:");
valorProduto = double.Parse(Console.ReadLine());

float d = 10f / 100f;

valorDesconto = valorProduto - (valorProduto * d);

Console.WriteLine($"O valor do produto com 10% de desconto é: {valorDesconto.ToString("F2")}");