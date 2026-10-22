/*
 Problema 22. Calculadora básica

Recibe dos números enteros y un operador (`+`, `-`, `*`, `/`) y guarda el resultado de la operación en una variable. 
Si se intenta dividir entre cero, el programa debe lanzar una excepción con el mensaje `No se puede dividir entre cero`. Si el operador no es válido, 
debe lanzar una excepción con el mensaje `Operador no soportado`.

- 12, 4, ‘*’ → `12 * 4 = 48`
- 10, 0, ‘/’ → excepción `No se puede dividir entre cero`
- 5, 2, ‘%’ → excepción `Operador no soportado`
*/

Console.WriteLine(" ingrese el primer numero -> ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine(" ingrese el segundo numero -> ");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine(" ingrese el operador (`+`, `-`, `*`, `/`) -> ");
char operador = char.Parse(Console.ReadLine());

if (operador == '/')
{
    if (numero2 == 0)
    {
        Console.WriteLine("No se puede dividir entre cero");
    }else
    {
        Console.WriteLine($"El resultado de la operacion fue -> {numero1 / numero2}");
    }
}else if (operador == '*')
{
    Console.WriteLine($"El resultado de la operacion fue -> {numero1 * numero2}");
}else if (operador == '-')
{
    Console.WriteLine($"El resultado de la operacion fue -> {numero1 - numero2}");
}else if (operador == '+')
{
    Console.WriteLine($"El resultado de la operacion fue -> {numero1 + numero2}");
}else
{
    Console.WriteLine("Operador no soportado") ;
}

