/*
 Problema 27. Taquilla de cine

El precio de la boleta depende de dos datos a la vez: el día (texto: “lunes” … “domingo”) y si la persona es estudiante (sí/no).

- Los martes la boleta cuesta $7.000 para todos.
- De lunes a viernes (excepto martes), un estudiante paga $9.000 y un no estudiante $12.000.
- Sábado y domingo cuesta $15.000 para todos.

Ejemplos: (“martes”, no) → `$7.000` · (“jueves”, sí) → `$9.000` · (“jueves”, no) → `$12.000` · (“sábado”, sí) → `$15.000`
*/

Console.WriteLine("Que dia de la semana es -> ");
string diaSemana = Console.ReadLine();

if (diaSemana == "martes")
{
    Console.WriteLine("La boleta son $7.000");
}else if (diaSemana == "sabado" || diaSemana == "domingo")
{
    Console.WriteLine("La boleta son 15.000");
}else if (diaSemana == "lunes" || diaSemana == "miercoles" || diaSemana == "jueves" || diaSemana == "viernes")
{
    Console.WriteLine("Eres estudiante? (si / no) -> ");
    string estudiante = Console.ReadLine();

    if (estudiante == "si")
    {
        Console.WriteLine("La boleta son $9.000");
    }
    else if (estudiante == "no")
    {
        Console.WriteLine("La boleta son $12.000");
    }
    else
    {
        Console.WriteLine("Dato invalido");
    }
}else
{
    Console.WriteLine("Dia invalido");
}