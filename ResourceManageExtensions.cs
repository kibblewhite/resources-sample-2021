namespace resources_sample_2021;

public static class ResourceManageExtensions
{

    private static readonly ConcurrentDictionary<Type, IEnumerable<CultureInfo>> _resource_cultures = new();

    /// <summary>
    /// Returns an IEnumerable collection of CultureInfo entries that is supported by the given ResourceManager derived from a Resource Assembly (*.resx)
    /// </summary>
    /// <param name="manager"></param>
    /// <returns></returns>
    static public IEnumerable<CultureInfo> SupportedCultured(this ResourceManager manager)
    {
        return _resource_cultures.GetOrAdd(manager.ResourceSetType, (t) => CultureInfo.GetCultures(CultureTypes.AllCultures).Where(c => !c.Equals(CultureInfo.InvariantCulture) && manager.GetResourceSet(c, true, false) != null));
    }

}

