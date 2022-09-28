﻿using Examples;
using System.Globalization;
using System.Text;
using static Examples.Delegate;

#region TypeConversion
/*Stock msft = new Stock();
Asset a = msft; // Upcast
Stock s = (Stock)a; // Downcast

House mansion = new House { Name = "McMansion", Mortgage = 250000 };
Asset b = mansion;
Console.WriteLine(mansion.Liability); // 250000
Console.WriteLine(b.Liability);*/
#endregion

#region Delegate
/*NoParameters noParameters = ShowMessage; //Delegate
noParameters(); //Singlecast
noParameters += ShowMultiCasting;
noParameters();//Multicast

WithParameters withParameters = ShowMessage2;
withParameters("Ganjali", "Imanov");
Console.ReadLine();

StockExchangeMonitor stockExchange = new StockExchangeMonitor();
stockExchange.PriceChangeHandler = ShowPrice; 
stockExchange.Start();
void ShowPrice(int price)
{
    Console.WriteLine($"New price {price}");
}*/
#endregion

#region String and TextHandling
/*char a = 'a';
Console.WriteLine(Char.IsLetter(a));
StringBuilder strB = new StringBuilder();
for (int i = 0; i < 10; i++)
{
    strB.Append("Modified ");
}
Console.WriteLine(strB.Length);
for (int j = 0; j < strB.Length; j++)
{
    Console.Write($"{strB[j]}");
}*/
#endregion

#region DateTimes
/*TimeSpan nearlyTenDays = TimeSpan.FromDays(10) - TimeSpan.FromSeconds(1);
Console.WriteLine(nearlyTenDays.Days); // 9
Console.WriteLine(DateTime.MinValue);
Console.WriteLine(DateTime.MaxValue);
Console.WriteLine(DateTimeOffset.UtcNow);
DateTime dt = new DateTime(2000, 2, 3,
    10, 20, 30);
DateTime bakuTime = new DateTime(2022, 09, 28, 10, 05, 54);
string dateFormat = bakuTime.ToString("dd.MM.yyyy"); // We can change format of date
Console.WriteLine(dateFormat);*/
#endregion

#region Parse
string s = true.ToString(); // s = "True"
bool b = bool.Parse(s); // b = true
Console.WriteLine(b);

bool failure = int.TryParse("qwerty", out int i1);
bool success = int.TryParse("123", out int i2);
i1 = 4;
i2 = 5;
Console.WriteLine(failure);
Console.WriteLine(success);
#endregion

#region Format
NumberFormatInfo f = new NumberFormatInfo();
f.CurrencySymbol = "$$";
Console.WriteLine(3.ToString("C", f));
#endregion