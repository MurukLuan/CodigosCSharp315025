/*
string mensagem = "Minha primeira mensagem";

Console.WriteLine(mensagem);

int numero1 = 5;
int numero2 = 5;
int resultado;
resultado = numero1 + numero2;
Console.WriteLine("o resultado da soma é: " + resultado);
*/

/*
string nome = "Luan Muruk";
int idade = 32;
char sexo = 'M';
double salario = 1280.65;

Console.WriteLine(nome + ", tem " + idade + " anos, é do sexo " + sexo
    +", e seu salario é de: " + salario);

Console.WriteLine("{0}, tem {1} anos, e é do sexo {2}, e seu salario" +
    " é de {3}", nome, idade, sexo, salario);

Console.WriteLine($"{nome}, tem {idade} anos, e é do sexo {sexo}" +
    $", e seu salario é de {salario}");
*/

string nome;
int idade;
char sexo;
double salario;

Console.WriteLine("Entre com seu nome");
nome = Console.ReadLine();

Console.Write("Entre com sua idade: ");
idade = int.Parse(Console.ReadLine());

Console.Write("Entre com o salario: ");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com o sexo: ");//informação do que o usuario deve inserir
sexo = char.Parse(Console.ReadLine()); //informação recebida via teclado

//mostrando as informações recebidas via teclado
Console.WriteLine("O sexo digitado foi: " + sexo);
Console.WriteLine("O nome digitado foi: " + nome);
Console.WriteLine("O salario digitado foi: " + salario.ToString("F5"));//o f5 está dizendo quantas casas decimais deve mostrar apos a virgula
Console.WriteLine("A idade digitada foi: " + idade);