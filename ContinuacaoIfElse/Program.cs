using System.Globalization;

double teste = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine(teste.ToString("F2", CultureInfo.InvariantCulture));


Console.WriteLine("Entre com o primeiro numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Min(num1, num2));

Console.WriteLine(Math.Max(num1 , num2));

Console.WriteLine(Math.Sqrt(num1));

Console.WriteLine(Math.Pow(num2, 3));

Console.WriteLine(Math.Round(25.61534, 2));

Console.WriteLine(Math.PI * 2);

Console.WriteLine($"O maior numero é {Math.Max(10, 20)}");


