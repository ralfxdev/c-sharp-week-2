//Escribe un programa que lea una cadena de texto y la imprima en mayúsculas.
string input, upperCaseString;

try
{
    Console.WriteLine("Por favor, ingresa una cadena de texto:");
    input = Console.ReadLine()!;

    upperCaseString = input.ToUpper();
    Console.WriteLine($"{upperCaseString}");

}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}