// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int edad = 18;

Console.WriteLine("Ingrese su edad:");
// Convertir la entrada a un número entero
edad = Convert.ToInt32(Console.ReadLine());

if (edad >= 18)
    Console.WriteLine("Eres mayor de edad");
else
    Console.WriteLine("Eres menor de edad");
    
// Operador ternario
string resultado = (edad >= 18) ? "Eres mayor de edad" : "Eres menor de edad";
Console.WriteLine(resultado);

