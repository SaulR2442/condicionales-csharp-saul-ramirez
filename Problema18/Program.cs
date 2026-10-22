/*
 Problema 18. Montaña rusa

Para subir a la montaña rusa, una persona debe medir al menos 1,40 m y además tener 12 años o más, a menos que vaya acompañada por un adulto,
en cuyo caso basta con la estatura. Determina si puede subir.

- Estatura 1,50, edad 13, sin acompañante → `Puede subir`
- Estatura 1,45, edad 10, con acompañante → `Puede subir`
- Estatura 1,45, edad 10, sin acompañante → `No puede subir`
- Estatura 1,30, edad 15, con acompañante → `No puede subir`
*/

Console.WriteLine("Ingrese su estatura (metros) -> ");
float estatura = float.Parse(Console.ReadLine());

if (estatura >= 1.40)
{
    Console.WriteLine("Ingrese su edad (años) -> ");
    byte edad = byte.Parse(Console.ReadLine());
    
    if (edad >= 12)
    {
        Console.WriteLine("Puede subir");
    }else
    {
        Console.WriteLine("Vienes con un adulto? (si / no)-> ");
        string adulto = Console.ReadLine();

        if (adulto == "si")
        {
            Console.WriteLine("Puede subir");
        }else
        {
            Console.WriteLine("No puede subirse a la montaña rusa.");
        }
    }
}
else
{
    Console.WriteLine("No puede subirse a la montaña rusa.");
}