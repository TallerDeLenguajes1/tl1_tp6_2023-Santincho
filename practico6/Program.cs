/////// EJERECICIO 2 ///////

int op;
Console.WriteLine("-------MENU-------");
Console.WriteLine("1- Sumar");
Console.WriteLine("2- Restar");
Console.WriteLine("3- Multiplicar");
Console.WriteLine("4- Dividir");
do
{
    Console.WriteLine("Seleccione la opcion que desea: ");
    op = Console.Read();
} while (op > 52 | op <= 48);

bool resulA, resulB;
int numA, numB;
Console.WriteLine("Ingrese 2 numeros: ");
do
{
    Console.WriteLine("Ingrese el numero A: ");
    resulA = int.TryParse(Console.ReadLine(),out numA);
} while (!resulA);

do
{
    Console.WriteLine("Ingrese el numero B: ");
    resulB = int.TryParse(Console.ReadLine(),out numB);
} while (!resulB);

int operacion;

switch (op)
{
    case 49:
        operacion = numA + numB;
        Console.Write("Resultado: "+operacion);
        break;
    case 50:
        operacion = numA - numB;
        Console.Write("Resultado: "+operacion);
        break;
    case 51:
        operacion = numA * numB;
        Console.Write("Resultado: "+operacion);
        break;
    case 52:
        if (numB != 0)
        {
            operacion = numA / numB;
            Console.Write("Resultado: "+operacion);
        } else
        {
            Console.WriteLine("Sintax Error");
        }
        break;
}