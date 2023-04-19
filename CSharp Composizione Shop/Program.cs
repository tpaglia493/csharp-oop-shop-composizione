/*
si possa inserire la lista di prodotti inziali o eventualmente una lista di prodotti nuovi che tratterò in più da oggi in poi nel negozio.
si possa inserire anche un prodotto singolo in più al negozio
si possa chiedere ad uno shop di darmi la sua rappresentazione in stringa e io possa stamparla in Console.
A questo punto provate a creare qualche prodotto, ed inserirlo in una lista di prodotti iniziali.

Create il vostro shop e aggiungetegli la lista iniziale dei prodotti. 
Stampate le informazioni del negozio (avvalendovi del metodo fatto nel negozio)
e assicuratevi che i prodotti iniziali (o aggiunti anche successivamente)
vengano stampati bene e in maniera corretta nel modo corretto visto in classe.
Provate ad aggiungere un nuovo prodotto allo shop, o una lista nuova di prodotti che volete che lo shop tratti
e provate a ristampare le informazioni del negozio con i nuovi prodotti via via aggiornati in Console.
Aggiungete poi ai vostri prodotti anche una Categoria ( o Category ) avvalendovi sempre del metodo della composizione, 
questa volta dentro il vostro Prodotto, in modo che potete tenere traccia della categoria di ogni prodotto. 
La categoria, oltre al semplice nome, potrebbe avere una descrizione e un codice identificativo ad uso interno.


BONUS:
Fate in modo che uno shop possa anche essere costruito fin da subito con una lista di prodotti iniziali, e non aggiunti a posteriori e basta.
Fate in modo che possa chiedere al negozio istanziato, il numero di prodotti che tratta attualmente. 
E se aggiungo nuovi prodotti questo numero incrementi di conseguenza rimanendo sempre coerente!
 */

using CSharp_Composizione_Shop;

Shop test1 = new Shop("fake name", "fake city", "fake street", 1234);
Console.WriteLine(test1.GetName());
Console.WriteLine(test1.GetCity());
Console.WriteLine(test1.GetStreet());
Console.WriteLine(test1.GetStreetNumber());
Console.WriteLine(test1.GetAddress());

test1.SetName("noName");
Console.WriteLine(test1.GetName());
Console.WriteLine(test1.GetAddress());

Product product1 = new Product("Table", "It's a table", 45.00f, 22.00f);
Product product2 = new Product("Chair", "It's a chair", 25.00f, 22.00f);
Product product3 = new Product("Spoon", "It's a spoon", 2.00f, 22.00f);
Product product4 = new Product("Table", "It's another more expensive table", 90.00f, 22.00f);

test1.AddSingleProductToList(product1);

foreach(Product product in test1.products)
{
    string info = product.GetInfo();
    Console.WriteLine(info);
}    