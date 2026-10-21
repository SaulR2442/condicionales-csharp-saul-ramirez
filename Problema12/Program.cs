/*
 Problema 12. Aprobación de crédito.

Un banco estudia solicitudes de crédito. Primero verifica si el solicitante tiene empleo. Si no tiene, el crédito se rechaza. Si tiene empleo, revisa su ingreso mensual: si gana $2.500.000 o más se aprueba un crédito alto; si gana menos, se aprueba un crédito básico.

- Sin empleo → `Crédito rechazado`
- Con empleo, ingreso $3.000.000 → `Crédito alto aprobado`
- Con empleo, ingreso $1.800.000 → `Crédito básico aprobado`
*/

Console.WriteLine("Tiene empleo (si / no)-> ") ;
string empleo = Console.ReadLine() ;

if (empleo == "si")
{
    Console.WriteLine("Ingrese sus ingresos mensuales -> ") ;
    int ingreso = int.Parse(Console.ReadLine()) ;

    if (ingreso >= 2500000)
    {
        Console.WriteLine("Credito alto aprovado.");
    }else
    {
        Console.WriteLine("Credito basico aprovado.");
    }
}
else
{
    Console.WriteLine("Credito rechazado.");
}