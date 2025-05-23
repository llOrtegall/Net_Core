using Operaciones;

Operaciones.Calculator calculator = new Operaciones.Calculator();

int resultadoSuma = calculator.Add(5, 3);
Console.WriteLine($"La suma de 5 y 3 es: {resultadoSuma}");

int resultadoResta = calculator.Subtract(5, 3);
Console.WriteLine($"La resta de 5 y 3 es: {resultadoResta}");

int resultadoMultiplicacion = calculator.Multiply(5, 3);
Console.WriteLine($"La multiplicación de 5 y 3 es: {resultadoMultiplicacion}");

double resultadoDivision = calculator.Divide(5, 3);
Console.WriteLine($"La división de 5 y 3 es: {resultadoDivision}");

