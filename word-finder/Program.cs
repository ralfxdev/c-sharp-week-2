//Escribe un programa que lea una cadena de texto y busque una palabra en ella.
string input, wordToSearch;

try
{
    Console.WriteLine("Por favor, ingresa una cadena de texto:");
    input = Console.ReadLine()!;

    Console.WriteLine("Por favor, ingresa la palabra que quieres buscar:");
    wordToSearch = Console.ReadLine()!;

    bool wordFound = input.Contains(wordToSearch);

    string message = wordFound ? 
        $"La palabra '{wordToSearch}' se encontró en la cadena." 
        : $"La palabra '{wordToSearch}' no se encontró en la cadena.";

    Console.WriteLine(message);

}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}