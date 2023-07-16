// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;

int b;

a = 10;

b = a;

Console.WriteLine("Valor de a: "+a);

Console.WriteLine("Valor de b: "+b);

/////// EJERECICIO 1 ///////

string num1;

int i;

bool resultado;

do
{
    do
    {
        Console.WriteLine("Escriba un numero");

        num1 = Console.ReadLine();

        i = 0;

        resultado = int.TryParse(num1, out i);
    } while (!resultado);
} while (i <= 0);

Console.WriteLine("El numero es: "+i);

int invertido = 0;

while (i != 0)
{
    invertido = invertido * 10 + i % 10;
    i = i / 10;
}

Console.WriteLine("El numero invertido es: "+invertido);