//Escribe un programa que calcule el volumen de una esfera.

try
{
    Console.WriteLine("Ingresa el radio de la esfera:");
    double radius = Convert.ToDouble(Console.ReadLine());

    // Calcular el volumen de la esfera utilizando la fórmula V = (4/3) * π * r^3
    // Math.Pow() se utiliza para elevar el radio a la potencia de 3
    double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

    Console.WriteLine($"El volumen de la esfera es: {volume}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}