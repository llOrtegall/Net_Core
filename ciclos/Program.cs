int contador = 10;

for (int i = 1; i <= contador; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("------------------------------------");

// Example de un ciclo while
int contador2 = 10;
while (contador2 > 0)
{
    Console.WriteLine(contador2);
    contador2--;
}

Console.WriteLine("------------------------------------");

// Example de un ciclo do forEach
Console.WriteLine("Por favor ingresa tu nombre: ");
string nombre = Console.ReadLine();

foreach (char letra in nombre)
{
    Console.WriteLine(letra);
}
