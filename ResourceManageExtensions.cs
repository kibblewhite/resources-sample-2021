namespace resources_sample_2021;

public static class ResourceManageExtensions
{

    private static readonly ConcurrentDictionary<Type, IEnumerable<CultureInfo>> _resource_cultures = new();

    /// <summary>
    /// Returns an IEnumerable collection of CultureInfo entries that is supported by the given ResourceManager derived from a Resource Assembly (*.resx)
    /// </summary>
    /// <param name="manager"></param>
    /// <returns></returns>
    static public IEnumerable<CultureInfo> SupportedCultures(this ResourceManager manager)
    {
        return _resource_cultures.GetOrAdd(manager.ResourceSetType, (t) => CultureInfo.GetCultures(CultureTypes.AllCultures).Where(x => x.Equals(CultureInfo.InvariantCulture) is false && manager.GetResourceSet(x, true, false) is not null));
    }

    /// <summary>
    /// Returns a string array of the supported culture names. Attempts to conform with BCP-47 (RFC 4647 + RFC 5646)
    /// </summary>
    /// <param name="manager"></param>
    /// <returns></returns>
    static public string[] SupportedCultureNamesAsArray(this ResourceManager manager)
    {
        IEnumerable<CultureInfo> supported_cultures = manager.SupportedCultures();
        return supported_cultures.Select(x => x.Name).ToArray();
    }

}
