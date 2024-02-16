//Escribe un programa que calcule la multiplicación de dos números flotantes.
float n1, n2, resultado;

try
{
    Console.WriteLine("Ingrese el primer flotante:");
    n1 = Convert.ToSingle(Console.ReadLine()!);

    Console.WriteLine("Ingrese el segundo flotante:");
    n2 = Convert.ToSingle(Console.ReadLine()!);

    resultado = n1 * n2;
    Console.WriteLine($"La multiplicación de {n1} * {n2} es: {resultado}");

}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}