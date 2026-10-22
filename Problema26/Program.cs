/*
 Problema 26. Peaje

Un peaje identifica el vehículo con una letra y asigna la tarifa a cobrar:

- ‘M’ moto: $0 (exenta)
- ‘A’ automóvil: $12.000
- ‘B’ bus: $25.000
- ‘C’ camión: $38.000
- Otra letra: se lanza una excepción con el mensaje `Categoría desconocida`

Imprime `Categoría X - Tarifa: $Y`.
*/

Console.WriteLine("Ingrese la letra del vehiculo -> ") ;
string letraVehiculo =  Console.ReadLine() ;

string tarifa = letraVehiculo switch 
{
    "M" => "0 (exenta)" ,
    "A" => "$12.000" ,
    "B" => "$25.000" ,
    "C" => "$38.000" ,
    _=> "Categoria desconocida."
};

Console.WriteLine($"Categoria: {letraVehiculo} - Tarifa: {tarifa}") ;