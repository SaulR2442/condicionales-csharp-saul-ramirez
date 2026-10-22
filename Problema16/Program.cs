/*
 Problema 16. Ubicación de un dron

El centro de control recibe la posición de un dron como un par de coordenadas con nombre (X, Y). Debe informar en qué cuadrante del plano cartesiano se encuentra, si está en el origen o si está sobre uno de los ejes.

- (3, 4) → `Primer cuadrante`
- (-2, -7) → `Tercer cuadrante`
- (0, 0) → `Origen`
- (0, 5) → `Sobre un eje`
*/

Console.WriteLine("Ingrese la coordenada X: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la coordenada Y: ");
int y = int.Parse(Console.ReadLine());

string ubicacion = (x, y) switch
{
    (0, 0) => "Origen",
    (0, _) or (_, 0) => "Sobre un eje", 
    (> 0, > 0) => "Primer cuadrante",
    (< 0, > 0) => "Segundo cuadrante",
    (< 0, < 0) => "Tercer cuadrante",
    (> 0, < 0) => "Cuarto cuadrante"
};

Console.WriteLine(ubicacion);