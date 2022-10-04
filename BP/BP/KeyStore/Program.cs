using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("\r\nExists Certs Name and Location");
Console.WriteLine("------ ----- -------------------------");

/*foreach (StoreLocation storeLocation in (StoreLocation[])
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
}*/


X509Store store = new X509Store("My", StoreLocation.LocalMachine);
store.Open(OpenFlags.ReadOnly);
X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;
foreach (X509Certificate2 x509 in collection)
{
    Console.WriteLine("certificate name: {0}", x509.Subject);
}
store.Close();

