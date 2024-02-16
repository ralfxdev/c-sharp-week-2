//Escribe un programa que lea una cadena de texto y cuente el número de vocales que contiene.
string input;

try
{
    Console.WriteLine("Por favor, ingresa una cadena de texto:");
    input = Console.ReadLine()!;

    int vowelCount = 0;
    foreach (char c in input.ToLower())
    {
        if ("aeiou".Contains(c))
        {
            vowelCount++;
        }
    }

    Console.WriteLine($"El número de vocales en la cadena es: {vowelCount}");

}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}