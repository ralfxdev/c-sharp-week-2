//Escribe un programa que convierta un entero a caracter.
int num;
char resultado;

try
{
    Console.WriteLine("Ingrese un entero:");
    num = Convert.ToInt32(Console.ReadLine()!);

    resultado = Convert.ToChar(num);
    Console.WriteLine($"Su conversión a cáracter es: {resultado}");

}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}