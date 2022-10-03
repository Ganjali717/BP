using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("\r\nExists Certs Name and Location");
Console.WriteLine("------ ----- -------------------------");

foreach (StoreLocation storeLocation in (StoreLocation[])
         Enum.GetValues(typeof(StoreLocation)))
{
    foreach (StoreName storeName in (StoreName[])
             Enum.GetValues(typeof(StoreName)))
    {
        X509Store store = new X509Store(storeName, storeLocation);

        try
        {
            store.Open(OpenFlags.OpenExistingOnly);

            Console.WriteLine("Yes    {0,4}  {1}, {2}",
                store.Certificates.Count, store.Name, store.Location);
        }
        catch (CryptographicException)
        {
            Console.WriteLine("No           {0}, {1}",
                store.Name, store.Location);
        }
    }
    Console.WriteLine();
}


