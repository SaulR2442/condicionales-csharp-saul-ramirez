/*
 Problema 5. El mayor de dos números

Dados dos números enteros, guarda en una variable `mayor` el más grande de los dos usando una sola línea de asignación, y luego imprímelo.

- Entrada: 14 y 9 → `El mayor es 14`
- Entrada: -2 y 3 → `El mayor es 3`
*/

Console.WriteLine("Ingrese el primer numero -> ") ;
int num1 = int.Parse(Console.ReadLine()) ;

Console.WriteLine("Ingrese el segundo numero -> ") ;
int num2 = int.Parse(Console.ReadLine()) ;

string mayor = num1 > num2 ? $"El mayor es {num1}." : num2 > num1 ? $"El mayor es {num2}." : "Los dos datos son iguales" ;

Console.WriteLine (mayor) ;