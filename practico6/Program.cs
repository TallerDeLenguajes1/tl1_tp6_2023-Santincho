/////// EJERECICIO 3 ///////
bool resulA;
double numA;
do
{
    Console.WriteLine("Ingrese un numero: ");
    resulA = double.TryParse(Console.ReadLine(),out numA);
} while (!resulA);

Console.WriteLine("Valor absoluto de " + numA + ": " + (double)Math.Abs(numA));
Console.WriteLine("Cuadrado de " + numA + ": " + (double)Math.Pow(numA, 2));
if (numA >= 0)
{
    Console.WriteLine("Raiz de " + numA +  ": " + (double)Math.Sqrt(numA));
} else
{
    Console.WriteLine("Raiz de " + numA +  ": SYNTAX ERROR");
}
Console.WriteLine("Seno de " + numA +  ": " + (double)Math.Sin(numA));
Console.WriteLine("Coseno de " + numA +  ": " + (double)Math.Cos(numA));
Console.WriteLine("Parte entera de " + numA +  ": " + (int)numA);

bool resul1, resul2;
double num1, num2;
Console.WriteLine("Ingrese dos numeros:");
do
{
    Console.WriteLine("Ingrese el numero 1: ");
    resul1 = double.TryParse(Console.ReadLine(),out num1);
} while (!resul1);

do
{
    Console.WriteLine("Ingrese el numero 2: ");
    resul2 = double.TryParse(Console.ReadLine(),out num2);
} while (!resul2);

if (num1 == num2)
{
    Console.WriteLine("Son iguales");
} else
{
    if (num1 > num2)
    {
        Console.WriteLine("El numero 1 es el maximo");
    } else
    {
        Console.WriteLine("El numero 2 es el maximo");
    }
}