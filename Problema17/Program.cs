/*
 Problema 17. Control de un reproductor

Un reproductor de música recibe comandos de texto: “play”, “pause”, “stop”, “next”. Cada comando imprime un mensaje distinto (`Reproduciendo...`, 
`En pausa`, `Detenido`, `Siguiente canción`). Un comando desconocido imprime `Comando no reconocido`.
*/

Console.WriteLine("Ingrese el comando que desee utilizar (play, pause, stop, next): ");
string comando = Console.ReadLine();

if (comando == "play")
{
    Console.WriteLine("Reproduciendo..") ;
}else if (comando == "pause") {
    Console.WriteLine("En pausa.");
}else if (comando == "Detenido")
{
    Console.WriteLine("Detenido");
}else if (comando == "next")
{
    Console.WriteLine("Siguiente cancion.");
}else
{
    Console.WriteLine("Comando no reconocido");
}