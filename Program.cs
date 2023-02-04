//// read file into a string and deserialize JSON to a type
//using System.Text.Json;

//Movie movie1 = JsonConvert.DeserializeObject<Movie>(File.ReadAllText(@"c:\movie.json"));

//// deserialize JSON directly from a file
//using (StreamReader file = File.OpenText(@"c:\movie.json"))
//{
//    JsonSerializer serializer = new JsonSerializer();
//    Movie movie2 = (Movie)serializer.Deserialize(file, typeof(Movie));
//}

using FavoritePizzaTopping;
using Newtonsoft.Json;

var allPizzas = JsonConvert.DeserializeObject<List<Pizza>>(File.ReadAllText(@"C:\Users\SBRud\OneDrive\Desktop\E20\FavoritePizzaTopping\Assets\pizzas.json"));

//var distinctToppings = holdMyPizza.Select(x => x.Toppings).Distinct();

Dictionary<string, int> pizzaCounter = new Dictionary<string, int>();

foreach (Pizza pizza in allPizzas)
{
    var toppingsAsString = String.Join(",", pizza.Toppings);

    if (pizzaCounter.ContainsKey(toppingsAsString))
    {
        pizzaCounter[toppingsAsString] += 1;
    }
    else
    {
        pizzaCounter[toppingsAsString] = 1;
    }

    //pizzaCounter.Add(toppingsAsString, 1);
}

  //  Console.WriteLine("\r\n ,ggg,         gg                                   ,ggggggggggg,                                      ,ggggggggggggggg                                                                \r\ndP\"\"Y8a        88                                  dP\"\"\"88\"\"\"\"\"\"Y8,                                   dP\"\"\"\"\"\"88\"\"\"\"\"\"\"                                                                \r\nYb, `88        88                                  Yb,  88      `8b                                   Yb,_    88                                                                       \r\n `\"  88        88                                   `\"  88      ,8gg                                   `\"\"    88                                  gg                                   \r\n     88        88                                       88aaaad8P\"\"\"                                          88                                  \"\"                                   \r\n     88        88   ,ggggg,  gg      gg  ,gggggg,       88\"\"\"\"\"   gg     ,gggg,    ,gggg,   ,gggg,gg          88  ,ggggg,  gg,gggg,   gg,gggg,    gg   ,ggg,,ggg,    ,gggg,gg   ,g,    \r\n     88       ,88  dP\"  \"Y8ggI8      8I  dP\"\"\"\"8I       88        88    d8\"  Yb   d8\"  Yb  dP\"  \"Y8I          88 dP\"  \"Y8ggI8P\"  \"Yb  I8P\"  \"Yb   88  ,8\" \"8P\" \"8,  dP\"  \"Y8I  ,8'8,   \r\n     Y8b,___,d888 i8'    ,8I I8,    ,8I ,8'    8I       88        88   dP    dP  dP    dP i8'    ,8I    gg,   88i8'    ,8I I8'    ,8i I8'    ,8i  88  I8   8I   8I i8'    ,8I ,8'  Yb  \r\n      \"Y88888P\"88,d8,   ,d8',d8b,  ,d8b,dP     Y8,      88      _,88,,dP  ,adP',dP  ,adP',d8,   ,d8b,    \"Yb,,8,d8,   ,d8',I8 _  ,d8',I8 _  ,d8'_,88,,dP   8I   Yb,d8,   ,d8I,8'_   8) \r\n           ,ad888P\"Y8888P\"  8P'\"Y88P\"`Y8P      `Y8      88      8P\"\"Y8\"   \"\"Y8d8\"   \"\"Y8dP\"Y8888P\"`Y8      \"Y8PP\"Y8888P\"  PI8 YY88888PI8 YY888888P\"\"Y8P'   8I   `YP\"Y8888P\"88P' \"YY8P8P\r\n          d8P\" 88                                                          ,d8I'     ,d8I'                                 I8         I8                                 ,d8I'         \r\n        ,d8'   88                                                        ,dP'8I    ,dP'8I                                  I8         I8                               ,dP'8I          \r\n        d8'    88                                                       ,8\"  8I   ,8\"  8I                                  I8         I8                              ,8\"  8I          \r\n        88     88                                                       I8   8I   I8   8I                                  I8         I8                              I8   8I          \r\n        Y8,_ _,88                                                       `8, ,8I   `8, ,8I                                  I8         I8                              `8, ,8I          \r\n         \"Y888P\"                                                         `Y8P\"     `Y8P\"                                   I8         I8                               `Y8P\"           \r\n");
var mostCommonPizzas = pizzaCounter.OrderByDescending(p => p.Value).Take(20);
foreach (var item in mostCommonPizzas)
{
    Console.WriteLine($" {item.Key} {item.Value}");
}
{

}

Console.WriteLine(mostCommonPizzas);
//using (StreamReader file = File.OpenText(@"C: \Users\SBRud\OneDrive\Desktop\E20\FavoritePizzaTopping\Assets\pizzas.json"))
//{
//    JsonSerializer serializer = new JsonSerializer();
//    Movie movie2 = 
//}
