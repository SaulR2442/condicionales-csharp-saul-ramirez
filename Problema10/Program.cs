/*
 Problema 10. Analizador de datos recibidos

Un sistema recibe datos en una variable de tipo `object` que puede contener un texto, un entero, un decimal (`double`) o un valor booleano. El programa debe describir el dato:

- Texto → `Texto de N caracteres`
- Entero → `Entero: valor`
- Decimal → `Decimal: valor`
- Booleano → `Booleano: valor`
- Otro → `Tipo no reconocido`

Ejemplos: “SENA” → `Texto de 4 caracteres` · 42 → `Entero: 42` · true → `Booleano: True`
*/

Console.WriteLine("Ingrese un dato para analizar -> ");
string entrada = Console.ReadLine()!;
object datoRecibido;

if (int.TryParse(entrada, out int numeroEntero))
{
    datoRecibido = numeroEntero;
}
else if (double.TryParse(entrada, out double numeroDecimal))
{
    datoRecibido = numeroDecimal;
}
else if (bool.TryParse(entrada, out bool valorBooleano))
{
    datoRecibido = valorBooleano;
}
else
{
    datoRecibido = entrada; 
}

string descripcion = datoRecibido switch
{
    string texto => $"Texto de {texto.Length} caracteres",
    int entero => $"Entero: {entero}",
    double nDecimal => $"Decimal: {nDecimal}",
    bool booleano => $"Booleano: {booleano}",
    _ => "Tipo no reconocido"
};

Console.WriteLine(descripcion);