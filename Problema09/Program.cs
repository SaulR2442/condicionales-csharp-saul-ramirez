/*
 Problema 9. Año bisiesto

Un año es bisiesto si es divisible entre 4 y no entre 100, o si es divisible entre 400. Determina si un año dado es bisiesto.

- 2024 → `Bisiesto` · 1900 → `No bisiesto` · 2000 → `Bisiesto`
*/

Console.WriteLine("Ingrese un año -> ") ;
int año = int.Parse(Console.ReadLine());

string añoBisiesto = (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0) ? $"El año {año}, es bisiesto." : $"El año {año}, no es bisiesto";

Console.WriteLine(añoBisiesto) ; 