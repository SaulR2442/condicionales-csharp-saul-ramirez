/*
 Problema 24. ¿Día hábil?

Dado el número de un día de la semana (1 = lunes … 7 = domingo), guarda en una variable si es `Día hábil` (lunes a viernes) o
`Fin de semana` (sábado y domingo). Cualquier otro número es `Día inválido`.

- 3 → `Día hábil` · 7 → `Fin de semana` · 0 → `Día inválido`
*/

Console.WriteLine("Ingrese el dia a la semana -> ");
byte numeroDia = byte.Parse(Console.ReadLine()) ;

string dia = numeroDia >= 1 && numeroDia <= 5 ? "Dia habil" : numeroDia >= 6 && numeroDia <= 7 ? "Fin de semana" : "Dia invalido" ;

Console.WriteLine(dia) ;