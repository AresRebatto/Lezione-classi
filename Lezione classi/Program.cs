//prenderemo tutti 10<----fax

using Lezione_classi;

Dado dado = new Dado();//System.Int32 (int) è un classe/tipo di dato
Dado secondoDado = new Dado("rosso", 8);//Utilizza il primo costruttore dove sono richiesti dei parametri

Console.WriteLine($"Il primo dado ha valore: {dado.LancioDadi()}");
Console.WriteLine("Il primo dado ha valore: " + secondoDado.LancioDadi());

Dado.Numero();

