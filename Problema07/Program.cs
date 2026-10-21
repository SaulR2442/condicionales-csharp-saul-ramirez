/*
 Problema 7. Signo de un número

Lee un número entero e indica si es positivo, negativo o cero.

- 8 → `Positivo` · -5 → `Negativo` · 0 → `Cero`
*/

Console.WriteLine("Ingrese un numero-> ") ;
int numero =int.Parse(Console.ReadLine()) ;

string signoNum = numero > 0 ? "Su numero es positivo." : numero < 0 ? "Su numero es negativo." : "Su numero es cero." ;

Console.WriteLine(signoNum) ;