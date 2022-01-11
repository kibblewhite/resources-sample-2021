
IEnumerable<CultureInfo> supported_cultures = Resource.ResourceManager.SupportedCultures();
Console.WriteLine("Supported Cultures using Resource Manager");
foreach (CultureInfo culture in supported_cultures)
{
    Console.WriteLine($"> {culture.EnglishName}");
}
Console.WriteLine(" ==================== ");

Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-GB");
Console.WriteLine($"CurrentThread.CurrentUICulture: {Thread.CurrentThread.CurrentUICulture.Name}");
Console.WriteLine($"Direct Test Value for Culture: {Resource.Test}");
Console.WriteLine(" -------------------- ");

string name_of_property = "Test";
Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-ES");
Console.WriteLine($"CurrentThread.CurrentUICulture: {Thread.CurrentThread.CurrentUICulture.Name}");
Console.WriteLine($"Direct Test Value for Culture: {Resource.ResourceManager.GetString(name_of_property)}");
Console.WriteLine(" -------------------- ");

Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("de-DE");
Console.WriteLine($"CurrentThread.CurrentUICulture: {Thread.CurrentThread.CurrentUICulture.Name}");
Console.WriteLine($"Direct Test Value for Culture: {Resource.Test}");
Console.WriteLine(" -------------------- ");

Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
Console.WriteLine($"CurrentThread.CurrentUICulture: {Thread.CurrentThread.CurrentUICulture.Name}");
Console.WriteLine($"Direct Test Value for Culture: {Resource.Test}");
Console.WriteLine(" -------------------- ");


Console.ReadLine();
