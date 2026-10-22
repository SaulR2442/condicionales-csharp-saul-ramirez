/*
 Problema 28. Descuento por compra

Un almacén aplica descuentos según el valor de la compra:

- $500.000 o más: 15 %
- $200.000 a menos de $500.000: 10 %
- $100.000 a menos de $200.000: 5 %
- Menos de $100.000: sin descuento

Además, si el cliente está inscrito en el programa de cliente frecuente y la compra es de $100.000 o más, recibe un 5 % adicional. 
El programa muestra el valor de la compra, el porcentaje total de descuento y el total a pagar.

- $250.000, frecuente → descuento 15 %, total $212.500
- $250.000, no frecuente → descuento 10 %, total $225.000
- $80.000, frecuente → descuento 0 %, total $80.000
*/

Console.WriteLine ("Ingrese el valor de la compra ->");
int valorCompra = int.Parse (Console.ReadLine());

if (valorCompra >= 100000)
{
    Console.WriteLine ("Esta inscrito en el programa de cliente frecuente (si / no)->");
    string clienteFrecuente = Console.ReadLine();
    
    if (clienteFrecuente == "si")
    {
        if (valorCompra < 200000)
        {
            Console.WriteLine($"Compra total -> {valorCompra}, Descuento total -> 10%, total {valorCompra - (valorCompra*0.10)}" );
        }else if (valorCompra < 500000)
        {
            Console.WriteLine($"Compra total -> {valorCompra}, Descuento total -> 15%, total {valorCompra - (valorCompra*0.15)}" );
        }else if (valorCompra >= 500000)
        {
            Console.WriteLine($"Compra total -> {valorCompra}, Descuento total -> 20%, total {valorCompra - (valorCompra*0.20)}" );
        }
        else
        {
            Console.WriteLine("Dato incorrecto.");
        }
    }else if (clienteFrecuente == "no")
    {
        if (valorCompra < 200000)
        {
            Console.WriteLine($"Compra total -> {valorCompra}, Descuento total -> 5%, total {valorCompra - (valorCompra*0.05)}" );
        }else if (valorCompra < 500000)
        {
            Console.WriteLine($"Compra total -> {valorCompra}, Descuento total -> 10%, total {valorCompra - (valorCompra*0.10)}" );
        }else if (valorCompra >= 500000)
        {
            Console.WriteLine($"Compra total -> {valorCompra}, Descuento total -> 15%, total {valorCompra - (valorCompra*0.15)}" );
        }
        else
        {
            Console.WriteLine("Dato incorrecto.");
        }
    }
}else
{
    Console.WriteLine($"Compra total: {valorCompra}, no tiene ningun tipo de descuento.");
}