/*


BONUS:
Fate in modo che uno shop possa anche essere costruito fin da subito con una lista di prodotti iniziali, e non aggiunti a posteriori e basta.
Fate in modo che possa chiedere al negozio istanziato, il numero di prodotti che tratta attualmente. 
E se aggiungo nuovi prodotti questo numero incrementi di conseguenza rimanendo sempre coerente!
 */

using CSharp_Composizione_Shop;
//CATEGORIES
Category dress = new Category("Dress", "Something you wear");
Category furniture = new Category("Furniture", "Basic furnitures for every house");
Category tool = new Category("Tool", "You can use it to do things");
Category book = new Category("Book", "Can use it to read");

//INITIALIZE THE [OBJECT]SHOP
Shop test1 = new Shop("fake name", "fake city", "fake street", 1234);


//INITIALIZE PRODUCTS 
Product product1 = new Product("Table", "It's a table", 45.00f, 22.00f, furniture);
Product product2 = new Product("Chair", "It's a chair", 25.00f, 22.00f, furniture);
Product product3 = new Product("Spoon", "It's a spoon", 2.00f, 22.00f, tool);
Product product4 = new Product("Expensive dress", "It's an expensive dress", 900.00f, 22.00f, dress);

//ADDING SINGLE PRODUCT TO LIST OF PRODUCTS OF SHOP NAMED test1
test1.AddSingleProductToProducts(product1);


//CREATING ANOTHER LIST 
List<Product> summerCollection = new List<Product>();
summerCollection.Add(product1);
summerCollection.Add(product2); 
summerCollection.Add(product3);
summerCollection.Add(product4);


//CONCATENATE LIST TO SHOP LIST
test1.ConcatListToProducts(summerCollection);

foreach (Product product  in test1.products)
{

    string info = product.GetCategory().GetCategoryInfo();
     info += product.GetInfo();
    Console.WriteLine(info);
}

