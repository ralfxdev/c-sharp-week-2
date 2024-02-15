//Escribe un programa que convierta un caracter a entero.
char character;
int resultado;

try
{
    Console.WriteLine("Ingrese un cáracter:");
    character = Convert.ToChar(Console.ReadLine()!);

    resultado = Convert.ToInt32(character);
    Console.WriteLine($"Su conversión a entero es: {resultado}");

}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}