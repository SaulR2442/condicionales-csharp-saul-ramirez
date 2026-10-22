/*
 Problema 15. Índice de masa corporal

Calcula el IMC con la fórmula peso / (estatura × estatura), peso en kg y estatura en metros, y clasifica el resultado. 
Se deben mostrar el valor del IMC con un decimal y la categoría:

- Menos de 18,5: Bajo peso
- De 18,5 a menos de 25: Peso normal
- De 25 a menos de 30: Sobrepeso
- 30 o más: Obesidad
*/

Console.WriteLine("Ingrese su estatura (Metros) -> ") ;
float estatura = float.Parse(Console.ReadLine()) ;

Console.WriteLine("Ingrese su estatura (Kilos) -> ") ;
float peso = float.Parse(Console.ReadLine()) ;

float imc = peso / (estatura * estatura) ;

string formula = imc < 18.5 ? $"IMC: {imc} - Bajo peso" : imc < 25 ? $"IMC: {imc} - Peso normal" : imc < 30 ? $"IMC: {imc} - Sobrepeso" : $"IMC: {imc} - Obesidad";

Console.WriteLine(formula) ;