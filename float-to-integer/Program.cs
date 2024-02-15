//Escribe un programa que convierta un número flotante a entero.
float num;
int resultado;

try
{
    Console.WriteLine("Ingrese un flotante:");
    num = Convert.ToSingle(Console.ReadLine());

    resultado = Convert.ToInt32(num);
    Console.WriteLine($"Su conversión a entero es: {resultado}");

}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}