//Escribe un programa que calcule la temperatura en grados Fahrenheit a partir de la temperatura en grados Celsius.

try
{
    Console.WriteLine("Ingresa la temperatura en grados Celsius:");
    double celsius = Convert.ToDouble(Console.ReadLine());

    // Convertir la temperatura de Celsius a Fahrenheit utilizando la fórmula: F = (C * 9/5) + 32
    double fahrenheit = (celsius * 9 / 5) + 32;

    Console.WriteLine($"La temperatura en grados Fahrenheit es: {fahrenheit}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}