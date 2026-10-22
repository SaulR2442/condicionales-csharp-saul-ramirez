/* 
 Problema 21. Carrito de compras

La tienda virtual muestra cuántos artículos hay en el carrito. La palabra debe ir en singular si hay exactamente uno y en 
plural en cualquier otro caso. Construye el mensaje con una sola línea de asignación.

- 1 → `Tienes 1 artículo en el carrito`
- 3 → `Tienes 3 artículos en el carrito`
- 0 → `Tienes 0 artículos en el carrito`
*/

Console.WriteLine(" Cuantos articulos en al carrito -> ");
byte carrito = byte.Parse(Console.ReadLine());

string articulosCarrito = carrito > 1 ? $"Tienes {carrito}, en el carrito" : carrito == 1 ? "Tienes 1 articulo en el carrito" : "Tienes 0 articulos en el carrito";

Console.WriteLine(articulosCarrito) ;