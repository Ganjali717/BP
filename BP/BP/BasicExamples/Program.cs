using System.Collections;
using Examples;
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
/*string s = true.ToString(); // s = "True"
bool b = bool.Parse(s); // b = true
Console.WriteLine(b);

bool failure = int.TryParse("qwerty", out int i1);
bool success = int.TryParse("123", out int i2);
i1 = 4;
i2 = 5;
Console.WriteLine(failure);
Console.WriteLine(success);*/
#endregion

#region Format
/*NumberFormatInfo f = new NumberFormatInfo();
f.CurrencySymbol = "$$";
Console.WriteLine(3.ToString("C", f));*/
#endregion

#region Collections
/*int[] array1 = { 1, 2 };
int[] array2 = { 3, 4 };
int[] array3 = array1;
Console.WriteLine($"array1==array2 ? {array1 == array2}"); // The are not equal because they have different memory locations (FALSE)
Console.WriteLine($"array2==array3 ? {array2 == array3}"); 
Console.WriteLine($"array3==array1 ? {array3 == array1}");*/

/*var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam" };

//Add to list 
people.Add("Bob");
people.AddRange(new[] { "Sam", "Alice" }); 
people.Insert(0, "Eugene");
people.InsertRange(1, new string[] { "Mike", "Kate" });*/

/*//Remove from list
people.RemoveAt(1); 
people.Remove("Tom");
people.RemoveAll(person => person.Length == 3);
people.RemoveRange(1, 2);
people.Clear();*/

/*//Search and check element
var containsBob = people.Contains("Bob");     //  true
var containsBill = people.Contains("Bill");    // false
var existsLength3 = people.Exists(p => p.Length == 3);  // true
var existsLength7 = people.Exists(p => p.Length == 7);  // false
var firstWithLength3 = people.Find(p => p.Length == 3); // Tom
var lastWithLength3 = people.FindLast(p => p.Length == 3);  // Sam
List<string> peopleWithLength3 = people.FindAll(p => p.Length == 3);*/

/*//Get range and copy to array
var range = people.GetRange(1, 3);
string[] partOfPeople = new string[3];
people.CopyTo(0, partOfPeople, 0, 3);*/

/*//Reverse
people.Reverse();
var people2 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };
people2.Reverse(1, 3);*/

/*string[] people3 = { "Tom", "Sam", "Bob" };
IEnumerator peopleEnumerator = people3.GetEnumerator(); // get IEnumerator
while (peopleEnumerator.MoveNext())   // until returned false
{
    string item = (string)peopleEnumerator.Current; // get element at current position
    Console.WriteLine(item);
}
peopleEnumerator.Reset();*/

/*Week week = new Week(); //IEnumerable realizing 
foreach (var day in week)
{
    Console.WriteLine(day);
}*/
#endregion

#region LINQ
string[] names = { "Ganjali", "Ali", "Abbas" };
IEnumerable<string> filteredNames = names.Where(n => n.Length >= 4).Select(x => x.ToUpper()).OrderBy(x => x.Length);
foreach (string n in filteredNames)
    Console.WriteLine(n);
#endregion
