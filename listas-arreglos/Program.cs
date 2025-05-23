string nombre1 = "Pepito";
string nombre2 = "Juanito";

string[] nombres = new string[2];
nombres[0] = nombre1;
nombres[1] = nombre2;

Console.WriteLine("Los nombres son:");
for (int i = 0; i < nombres.Length; i++)
{
  Console.WriteLine(nombres[i]);
}

List<string> listaNombres = new List<string>();
listaNombres.Add("Pepito");
listaNombres.Add("Juanito");
listaNombres.Add("Maria");

Console.WriteLine("Los nombres en la lista son:");
foreach (string nombre in listaNombres)
{
  Console.WriteLine(nombre);
}

// example for switch case

switch (listaNombres[2])
{
  case "Pepito":
    Console.WriteLine("El nombre es Pepito");
    break;
  case "Juanito":
    Console.WriteLine("El nombre es Juanito");
    break;
  case "Maria":
    Console.WriteLine("El nombre es Maria");
    break;
  default:
    Console.WriteLine("El nombre no es Pepito ni Juanito");
    break;
}