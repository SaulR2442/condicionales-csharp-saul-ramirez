/*
 Problema 23. Inicio de sesión

Un sistema valida el acceso en dos pasos. Primero verifica que el usuario exista (el único usuario registrado es “aprendiz”). 
Si no existe, muestra `Usuario no encontrado`. Si existe, verifica la contraseña (“Sena2026”): si es correcta muestra `Bienvenido`; si 
no, muestra `Contraseña incorrecta`. Cada error debe tener su propio mensaje.

*/

string usuario = "aprendiz" ;
string contraseña = "Sena2026";

Console.WriteLine(" ingrese su usuario -> ");
string usuarioIntento = Console.ReadLine();

Console.WriteLine("-----Buscando usuario---------") ;

if (usuarioIntento == usuario)
{
    Console.WriteLine("-----usuario encontrado---------") ;
    Console.WriteLine(" ingrese su contraseña -> ");
    string contraseñaIntento = Console.ReadLine();

    if (contraseñaIntento == contraseña)
    {
        Console.WriteLine($"Bienvenido exitosamente usuario, {usuario}.");
    }else
    {
        Console.WriteLine("Contraseña incorrecta.") ;
    }
}else
{
    Console.WriteLine("Usuario no encontrado");
}