
string frase = "Luan é um Otimo professor, 1 e TrAbAlHa no SeNai";

Console.WriteLine(frase.ToLower()); //comando pra deixar todas as letras minusculas
Console.WriteLine(frase.ToUpper());//comando pra deixar todas as letras maiusculas
Console.WriteLine(frase.IndexOf('1'));//primeira posição do caractere indicado
Console.WriteLine(frase.LastIndexOf('N'));//ultima posição do caractere indicado

Console.WriteLine(frase.Substring(0 , 4));//recorta a string passando uma posição inicial e final
Console.WriteLine(frase.Substring(4));// recorta a string a partir da posição indicada

Console.WriteLine(frase.Replace('a', 'A'));//subistitui um caracter indicado por outro tambem indicado
Console.WriteLine(frase.Replace("Luan", "Rafael"));//substitui uma palavra por outra

string frase2 = "123";

Console.WriteLine(string.IsNullOrEmpty(frase2));
Console.WriteLine(string.IsNullOrWhiteSpace(frase2));

int numero = int.Parse(frase2);

Console.WriteLine(numero + 2);//soma com a conversão realizada
Console.WriteLine(frase2 + 2);//concatena

Console.WriteLine(numero.ToString() + 10);//converte numero para string

Console.WriteLine(frase.Length); //conta quantidade de caractres
Console.WriteLine(frase.Count()); // conta quantidade de caracteres

