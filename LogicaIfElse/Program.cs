{
    /*
        > Maior que
        < Menor que
        >= Maior ou igual a
        <= Menor ou igual a
        != Diferente
        == igual
        !  Negação
     */
    //escopo global
    /*
    int num1;
    int num2;
    int num3;

    Console.WriteLine("Entre com o primeiro numero");
    num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Entre com o segundo numero");
    num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Entre com o terceiro numero");
    num3 = int.Parse(Console.ReadLine());

    /*
     Operadores lógicos
        && E ou and
        || operador OU ou or
        !  negação
     */
    /*
        if (num1 > num2 && num1 > num3)
        {
            //escopo local
            Console.WriteLine("num1 é o maior");
        }
        else if (num2 > num3)
        {
            Console.WriteLine("Numero2 é o maior");
        }
        else
        {
            Console.WriteLine("Numeró 3 é o maior");
        }
    */
    /*
    string nome;
    double salario;
    int dia;

    Console.WriteLine("Entre com seu nome");
    nome = Console.ReadLine();

    Console.WriteLine("Entre com seu salario");
    salario = double.Parse(Console.ReadLine());

    Console.WriteLine("Entre com o dia do mes");
    dia = int.Parse(Console.ReadLine());

    if(salario > 1200.00 || dia == 5)
    {
        Console.WriteLine("Hoje tô bonito!");
    }
    else if(salario <= 1200 || dia == 5)
    {
        Console.WriteLine("Ainda to bonito");
    }
    else
    {
        Console.WriteLine("ja to feio!");
    }
    */
    /*
    bool verdadeiro = true;
    bool falso = false;

    if(!verdadeiro == falso)
    {
        Console.WriteLine("entrou aqui");
    }
    else
    {
        Console.WriteLine("Entrou no segundo");
    }
    */

    /*
    Console.Write("Entre com um numero: ");
    int num = int.Parse(Console.ReadLine());

    if(num %2 == 0)
    {
        Console.WriteLine("Numero par!");
    }
    else
    {
        Console.WriteLine("Numero impar!");
    }
    */

    /*
    double porcento = 5;
    float percente = 10;

    Console.WriteLine(100 * 0.05 );
    Console.WriteLine(100 * 0.10 );
    */

    Console.WriteLine("entre com o ano para saber se é bissexto ou não");
    int ano = int.Parse(Console.ReadLine());

    if(ano %4 == 0)
    {
        Console.WriteLine("Ano bissexto");
    }
    else
    {
        Console.WriteLine("Ano não bissexto!");
    }

}