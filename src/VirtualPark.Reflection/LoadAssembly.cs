namespace VirtualPark.Reflection;

public sealed class LoadAssembly<TInterface>(string path) : ILoadAssembly<TInterface>
    where TInterface : class
{
    private readonly DirectoryInfo _directory = new(path);
    private List<Type> _implementations = [];

    public List<string?> GetImplementations()
    {
        throw new NotImplementedException();
    }

    public TInterface GetImplementation(string assemblyName, params object[] args)
    {
        throw new NotImplementedException();
    }
}
