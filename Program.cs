Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("----Los primeros 5 pares----\n");
Console.ResetColor();

int x = 2;
for (int i = x; x <= 10; x= x+2 )
{
    Console.WriteLine("Los numeros son: {0}\n ", x);
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("----Sume los primeros 10 numeros----\n");
Console.ResetColor();

int suma = 0;
for (int i = 1; i <= 10; i++)
    suma += i;
{
    Console.WriteLine("El resultado es " + suma);
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n----Solicita numero y luego suma----\n");
Console.ResetColor();

int num = 0;
int sum = 0;
Console.WriteLine("Ingrese numeros positivos: ");
num = int.Parse(Console.ReadLine());

while (num >= 0)
{
    sum += num;
    Console.WriteLine("Ingrese un numero positivo (o un negativo para terminar) ");
    num = int.Parse(Console.ReadLine());
}Console.WriteLine("La suma de los numeros positivos es: "+ sum);

//------------------------

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("----Numero entero divisible entre 7 y 11----\n");
Console.ResetColor();

int b = 0;

