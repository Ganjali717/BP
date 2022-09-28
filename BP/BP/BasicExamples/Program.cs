using Examples;
using static Examples.Delegate;

#region TypeConversion
Stock msft = new Stock();
Asset a = msft; // Upcast
Stock s = (Stock)a; // Downcast

House mansion = new House { Name = "McMansion", Mortgage = 250000 };
Asset b = mansion;
Console.WriteLine(mansion.Liability); // 250000
Console.WriteLine(b.Liability);
#endregion


#region Delegate
NoParameters noParameters = new(ShowMessage); //Delegate

noParameters(); //Singlecast

noParameters += ShowMultiCasting;
noParameters();//Multicast

WithParameters withParameters = new(ShowMessage2);
withParameters("Ganjali", "Imanov");
Console.ReadLine();

StockExchangeMonitor stockExchange = new StockExchangeMonitor();
stockExchange.PriceChangeHandler = ShowPrice; 
stockExchange.Start();
void ShowPrice(int price)
{
    Console.WriteLine($"New price {price}");
}
#endregion
