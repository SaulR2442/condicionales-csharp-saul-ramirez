/*
 Problema 3. Menú de cajero automático

El cajero muestra un menú: 1 = Consultar saldo, 2 = Retirar, 3 = Depositar, 4 = Salir. Según la opción digitada, el programa imprime la acción. Cualquier otro número muestra `Opción no válida`.

- Entrada: 2 → `Ha seleccionado: Retirar`
- Entrada: 9 → `Opción no válida`
*/

Console.WriteLine ("""
--------Menu-------
1. Consultar saldo.
2. Retirar.
3. Depositar.
4. Salir.
Ingrese su opcion (solamente el numero) ->  
""") ;
byte opcionMenu = byte.Parse (Console.ReadLine()) ;

string mensajeCliente = opcionMenu switch 
{
   1 => "Ha seleccionado: Consultar saldo.",
   2 => "Ha seleccionado: Retirar.",
   3 => "Ha seleccionado: Depositar.",
   4 => "Ha seleccionado: Salir.",
   _=> "Opcion no valida"
};

Console.WriteLine(mensajeCliente) ;