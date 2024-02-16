//Escribe un programa que lea una cadena de texto y la imprima en minúsculas.
string input, lowerCaseString;

try
{
    Console.WriteLine("Por favor, ingresa una cadena de texto:");
    input = Console.ReadLine()!;

    lowerCaseString = input.ToLower();
    Console.WriteLine($"{lowerCaseString}");

}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}