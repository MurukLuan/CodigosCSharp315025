/*
int numero1;
int numero2;

Console.WriteLine("Entre com o primeiro numero: ");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o segundo numero: ");
numero2 = int.Parse(Console.ReadLine());

Console.WriteLine($"O maior numero é: {Math.Max(numero1 , numero2)}");

    if(numero1 > numero2)
    {
        Console.WriteLine("O maior numero é: " + numero1);
    }
    else
    {
        Console.WriteLine($"O maior numero é: {numero2}");
    }

string resultado = numero1 > numero2 ? $"Omaior numero é: {numero1}" : $"O maior numero é: {numero2}";
Console.WriteLine(resultado);

*/

double nota1;
double nota2;
double nota3;
double nota4;
double media;

Console.Write("Entre com a primeira nota: ");
nota1 = double.Parse(Console.ReadLine());

Console.Write("Entre com a segunda nota: ");
nota2 = double.Parse(Console.ReadLine());

Console.Write("Entre com a terceira nota: ");
nota3 = double.Parse(Console.ReadLine());

Console.Write("Entre com a quarta nota: ");
nota4 = double.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

    if(media >= 7.0)
    {
        Console.WriteLine($"Aluno aprovado! Media: {media}");
    }
    else if(media < 7.0 && media >= 6.0)
    {
        Console.WriteLine("Aluno ficou de recuperação. Media: " + media);
    }
    else
    {
        Console.WriteLine("Reprovou por media. Media: " + media);
    }

