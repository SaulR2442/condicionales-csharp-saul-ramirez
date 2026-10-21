/*
 Problema 8. Vocal o consonante

Lee una letra minúscula e indica si es vocal (a, e, i, o, u) o consonante. Si el carácter no es una letra del alfabeto, debe mostrar `No es una letra`.

- ‘e’ → `Es vocal` · ‘m’ → `Es consonante` · ‘7’ → `No es una letra`
*/

Console.WriteLine("Ingrese el caracter -> ") ;
char caracter = char.Parse(Console.ReadLine());

string vocal = caracter switch 
{
   'a' or 'e' or 'i' or 'o' or 'u' => "Es vocal.",
    'b' or 'c' or 'd' or 'f' or 'g' or 'h' or 'j' or 'k' or 'l' or 'm' or 'n' or 'ñ' or 'p' or 'p' or 'q' or 'r' or 's' or 't' or 'v' or 'w' or 'x' or 'y' or 'z' => "Es consonate.",
    _=> "No es letra."
};

Console.WriteLine(vocal) ;