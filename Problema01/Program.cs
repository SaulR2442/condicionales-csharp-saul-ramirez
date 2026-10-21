/* 
Problema 1. Registro electoral

La Registraduría necesita un programa que reciba la edad de una persona e informe si puede votar (16 años o más en este ejercicio) o si todavía no puede hacerlo.

- Entrada: 17 → Salida: `Puede votar`
- Entrada: 15 → Salida: `Aún no puede votar`
*/

Console.WriteLine ("Ingrese su edad, para saber si puede votar -> ") ;
sbyte edad = sbyte.Parse ( Console.ReadLine() ) ;

string mensaje = edad >= 16 ? "Puede votar" : "Aun no puede votar" ;
Console.WriteLine(mensaje) ; 