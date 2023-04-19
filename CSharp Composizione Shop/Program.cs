/*
si possa inserire la lista di prodotti inziali o eventualmente una lista di prodotti nuovi che tratterò in più da oggi in poi nel negozio.
Aggiungete poi ai vostri prodotti anche una Categoria ( o Category ) avvalendovi sempre del metodo della composizione, 
questa volta dentro il vostro Prodotto, in modo che potete tenere traccia della categoria di ogni prodotto. 
La categoria, oltre al semplice nome, potrebbe avere una descrizione e un codice identificativo ad uso interno.


BONUS:
Fate in modo che uno shop possa anche essere costruito fin da subito con una lista di prodotti iniziali, e non aggiunti a posteriori e basta.
Fate in modo che possa chiedere al negozio istanziato, il numero di prodotti che tratta attualmente. 
E se aggiungo nuovi prodotti questo numero incrementi di conseguenza rimanendo sempre coerente!
 */

using CSharp_Composizione_Shop;


//INITIALIZE THE [OBJECT]SHOP
Shop test1 = new Shop("fake name", "fake city", "fake street", 1234);

//TESTING GETTERS AND SETTERS
Console.WriteLine(test1.GetName());
Console.WriteLine(test1.GetCity());
Console.WriteLine(test1.GetStreet());
Console.WriteLine(test1.GetStreetNumber());
Console.WriteLine(test1.GetAddress());
test1.SetName("noName");
Console.WriteLine(test1.GetName());
Console.WriteLine(test1.GetAddress());

//INITIALIZE PRODUCTS 
Product product1 = new Product("Table", "It's a table", 45.00f, 22.00f);
Product product2 = new Product("Chair", "It's a chair", 25.00f, 22.00f);
Product product3 = new Product("Spoon", "It's a spoon", 2.00f, 22.00f);
Product product4 = new Product("Table", "It's another more expensive table", 90.00f, 22.00f);

//ADDING SINGLE PRODUCT TO LIST OF PRODUCTS OF SHOP NAMED test1
test1.AddSingleProductToProducts(product1);


//PRINTING INFO OF ALL PRODUCTS IN THE LIST
/*
foreach(Product product in test1.products)
{
    string info = product.GetInfo();
    Console.WriteLine(info);
}    
*/

//CREATING ANOTHER LIST 
List<Product> summerCollection = new List<Product>();
summerCollection.Add(product1);
summerCollection.Add(product2); 
summerCollection.Add(product3);
summerCollection.Add(product4);


//PRINTING INFO OF ALL PRODUCTS IN THE NEW LIST
/*
foreach (Product product in summerCollection)
{
    string info = product.GetInfo();
    Console.WriteLine(info);
} 
*/

//CONCATENATE LIST TO SHOP LIST
test1.ConcatListToProducts(summerCollection);

foreach (Product product in test1.products)
{
    string info = product.GetInfo();
    Console.WriteLine(info);
}