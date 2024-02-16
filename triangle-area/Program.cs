//Escribe un programa que calcule el área de un triángulo.

try
{
    Console.WriteLine("Ingresa la longitud de la base del triángulo:");
    double baseLength = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingresa la altura del triángulo:");
    double height = Convert.ToDouble(Console.ReadLine());

    double area = (baseLength * height) / 2;

    Console.WriteLine($"El área del triángulo es: {area}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}