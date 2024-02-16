//Escribe un programa que calcule la temperatura en grados Celsius a partir de la temperatura en grados Fahrenheit.

try
{
    Console.WriteLine("Ingresa la temperatura en grados Fahrenheit:");
    double fahrenheit = Convert.ToDouble(Console.ReadLine());

    // Convertir la temperatura de Fahrenheit a Celsius utilizando la fórmula: C = (F - 32) * 5/9
    double celsius = (fahrenheit - 32) * 5 / 9;

    Console.WriteLine($"La temperatura en grados Celsius es: {celsius}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}