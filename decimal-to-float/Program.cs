//Escribe un programa que convierta un número decimal a flotante.
decimal num;
float resultado;

try
{
    Console.WriteLine("Ingrese un decimal:");
    num = Convert.ToInt32(Console.ReadLine());

    resultado = Convert.ToSingle(num);
    Console.WriteLine($"Su conversión a flotante es: {resultado}");

}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}