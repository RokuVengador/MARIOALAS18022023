// tarea semana 4
using MARIOALAS18022023.Entidades;
using MARIOALAS18022023.Negocios;


ContadorLetras contadorletras = new ContadorLetras();
ClsContadorLetras clscontadorletras = new ClsContadorLetras();

Console.WriteLine("introduce una palabra: ");
string roku = Console.ReadLine();

contadorletras.texto = roku;

int resultado = clscontadorletras.contadores(contadorletras);

Console.WriteLine($"el numero de letras de tu palabra es: {resultado}");
