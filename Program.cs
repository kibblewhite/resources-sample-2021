
Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-GB");
Console.WriteLine($"CurrentThread.CurrentUICulture: {Thread.CurrentThread.CurrentUICulture.Name}");
Console.WriteLine($"Direct Test Value for Culture: {Resource.Test}");
Console.WriteLine(" -------------------- ");

Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-ES");
Console.WriteLine($"CurrentThread.CurrentUICulture: {Thread.CurrentThread.CurrentUICulture.Name}");
Console.WriteLine($"Direct Test Value for Culture: {Resource.Test}");
Console.WriteLine(" -------------------- ");

Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
Console.WriteLine($"CurrentThread.CurrentUICulture: {Thread.CurrentThread.CurrentUICulture.Name}");
Console.WriteLine($"Direct Test Value for Culture: {Resource.Test}");
Console.WriteLine(" -------------------- ");

Console.ReadLine();
