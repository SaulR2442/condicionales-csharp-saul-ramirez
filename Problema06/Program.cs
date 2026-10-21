/*
 Problema 6. Piedra, papel o tijera

Dos jugadores eligen “piedra”, “papel” o “tijera”. El programa recibe ambas jugadas y determina el resultado: piedra vence a tijera, tijera vence a papel, papel vence a piedra; si son iguales es empate.

- (“piedra”, “tijera”) → `Gana el jugador 1`
- (“piedra”, “papel”) → `Gana el jugador 2`
- (“papel”, “papel”) → `Empate`
*/

Console.WriteLine("Ingrese su movimiento (piedra, papael o tijera) -> ") ;
string jugador1 =Console.ReadLine() ;

Console.WriteLine("Ingrese su movimiento (piedra, papael o tijera) -> ") ;
string jugador2 = Console.ReadLine() ;

if (jugador1 == jugador2)
{
    Console.WriteLine("Empate") ;
}else if ((jugador1 == "piedra" && jugador2 == "tijera") || (jugador1 == "papel" && jugador2 == "piedra") || (jugador1 == "tijera" && jugador2 == "papel"))
{
    Console.WriteLine("Gana el jugador 1.") ;
}else if ((jugador2 == "piedra" && jugador1 == "tijera") || (jugador2 == "papel" && jugador1 == "piedra") || (jugador2 == "tijera" && jugador1 == "papel"))
{
    Console.WriteLine("Gana el jugador 2") ;
}else
{
    Console.WriteLine("Dato invalido");
}