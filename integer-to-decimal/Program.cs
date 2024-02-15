//Escribe un programa que convierta un número entero a decimal.
int num;
decimal resultado;

try
{
    Console.WriteLine("Ingrese un entero:");
    num = Convert.ToInt32(Console.ReadLine());

    resultado = Convert.ToDecimal(num);
    Console.WriteLine($"Su conversión a decimal es: {resultado}");

}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}