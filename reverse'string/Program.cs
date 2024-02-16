//Escribe un programa que lea una cadena de texto y la imprima al revés.
string input, reversedString;

try
{
    Console.WriteLine("Por favor, ingresa una cadena de texto:");
    input = Console.ReadLine()!;

    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);
    reversedString = new string(charArray);

    Console.WriteLine($"{reversedString}");

}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}