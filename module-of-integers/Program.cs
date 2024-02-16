//Escribe un programa que calcule el módulo de dos números enteros.
int n1, n2, resultado;

try
{
    Console.WriteLine("Ingrese el primer entero:");
    n1 = Convert.ToInt32(Console.ReadLine()!);

    Console.WriteLine("Ingrese el segundo entero:");
    n2 = Convert.ToInt32(Console.ReadLine()!);

    resultado = n1 % n2;
    Console.WriteLine($"El módulo de {n1} % {n2} es: {resultado}");

}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}