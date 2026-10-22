/*
 Problema 29. Control de acceso a la sede

El torniquete de la sede recibe dos datos: el rol de la persona (“admin”, “instructor”, “aprendiz”) y la hora de llegada (0 a 23). Las reglas son:

- “admin” puede entrar a cualquier hora.
- “instructor” puede entrar de 6 a 21 horas.
- “aprendiz” puede entrar de 6 a 18 horas.
- Cualquier otro caso: acceso denegado.

Ejemplos: (“admin”, 2) → `Acceso permitido` · (“aprendiz”, 19) → `Acceso denegado` · (“instructor”, 20) → `Acceso permitido`
*/

Console.WriteLine("Ingrese su rol ->");
string rol = Console.ReadLine();

if (rol == "admin")
{
    Console.WriteLine("Acceso permitido");
}else
{
    Console.WriteLine("Ingrese su hora de entrada->");
    byte horaEntrada = byte.Parse(Console.ReadLine());

    if ((horaEntrada >= 6 && horaEntrada <= 21) && (rol == "instructor")) 
    {
        Console.WriteLine("Acceso permitido.");
    }else if ((horaEntrada >= 6 && horaEntrada <= 18) && (rol == "aprendiz"))
    {
        Console.WriteLine("Acceso permitido.") ;
    }else
    {
        Console.WriteLine("Acceso denegado.") ;
    }
}