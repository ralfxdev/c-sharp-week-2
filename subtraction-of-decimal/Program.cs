//Escribe un programa que calcule la resta de dos números decimales.
decimal n1, n2, resultado;

try
{
    Console.WriteLine("Ingrese el primer decimal:");
    n1 = Convert.ToDecimal(Console.ReadLine()!);

    Console.WriteLine("Ingrese el segundo decimal:");
    n2 = Convert.ToDecimal(Console.ReadLine()!);

    resultado = n1 - n2;
    Console.WriteLine($"La resta de {n1} - {n2} es: {resultado}");

}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}