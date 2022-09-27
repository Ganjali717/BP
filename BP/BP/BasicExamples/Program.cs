using Examples;
using static Examples.Delegate;

/*Stock msft = new Stock();
Asset a = msft; // Upcast
Stock s = (Stock)a; // Downcast*/

/*
House mansion = new House { Name = "McMansion", Mortgage = 250000 };
Asset a = mansion;
Console.WriteLine(mansion.Liability); // 250000
Console.WriteLine(a.Liability);
*/

NoParameters noParameters = new(ShowMessage); //Delegate
noParameters();
Console.ReadLine();