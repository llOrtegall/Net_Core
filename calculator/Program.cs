int Suma(int a, int b)
{
  Console.WriteLine(a + b);
  return a + b;
}

int Resta(int a, int b)
{
  Console.WriteLine(a - b);
  return a - b;
}

int Multiplicacion(int a, int b)
{
  Console.WriteLine(a * b);
  return a * b;
}

int Division(int a, int b)
{
  if (b == 0)
  {
    Console.WriteLine("Error: Division by zero is not allowed.");
    return 0;
  }
  else
  {
    Console.WriteLine(a / b);
    return a / b;
  }
}

int resultadoSuma = Suma(5, 3);
int resultadoResta = Resta(5, 3);
int resultadoMultiplicacion = Multiplicacion(5, 3);
int resultadoDivision = Division(5, 0);
int resultadoDivision2 = Division(5, 2);