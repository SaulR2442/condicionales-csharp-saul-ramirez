/*
 Problema 11. Semáforo inteligente

Define un tipo con los estados posibles de un semáforo: Rojo, Amarillo y Verde. Según el estado actual, el programa imprime la instrucción para el conductor:

- Rojo → `Deténgase`
- Amarillo → `Precaución, prepárese para detenerse`
- Verde → `Avance`
*/
Console.WriteLine("Estado actual del semaforo -> ") ;
string semaforo = Console.ReadLine() ;

string estado = semaforo switch 
{
    "Rojo" => "Detengase.",
    "Amarillo" => "Preocupacion, preparense para detenerse.",
    "Verde" => "Avance",
    _=> "Instruccion invalida."
};

Console.WriteLine(estado) ;
