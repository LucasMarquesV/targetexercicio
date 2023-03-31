//Exercicio 1
Console.WriteLine("------Exercício 1------");

var index = 0;
var target = 13;
var soma = 0;

while (index < target)
{
    index++;
    soma += index;
}

Console.WriteLine(soma);


//Exercicio 2
Console.WriteLine("------Exercício 2------");

static bool ChecarFibonacci(int numero)
{
    var x = 0;
    var y = 1;

    while (y < numero)
    {
        int temp = x;
        x = y;
        y = temp + y;
    }

    return y == numero;
}

var numeroChecado = 9;

Console.WriteLine("O número escolhido foi {0}", numeroChecado);

if (ChecarFibonacci(numeroChecado))
    Console.WriteLine("{0} faz parte da sequência de Fibonacci.", numeroChecado);
else
    Console.WriteLine("{0} não faz parte da sequência de Fibonacci.", numeroChecado);


//Exercicio 5
Console.WriteLine("------Exercício 5------");

string frase = "Target Sistemas";
string inverso = "";

for (int i = frase.Length - 1; i >= 0; i--)
{
    inverso += frase[i];
}

Console.WriteLine("Frase original: {0}", frase);
Console.WriteLine("Frase invertida: {0}", inverso);


