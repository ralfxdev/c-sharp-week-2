//Escribe un programa que calcule la distancia entre dos puntos.

try
{
    Console.WriteLine("Ingresa las coordenadas (x1,y1) del primer punto:");
    double x1 = Convert.ToDouble(Console.ReadLine());
    double y1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingresa las coordenadas (x2,y2) del segundo punto:");
    double x2 = Convert.ToDouble(Console.ReadLine());
    double y2 = Convert.ToDouble(Console.ReadLine());

    // Calcular la distancia utilizando la fórmula de la distancia euclidiana: sqrt((x2-x1)^2 + (y2-y1)^2)
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    Console.WriteLine($"La distancia entre los puntos es: {distance}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}