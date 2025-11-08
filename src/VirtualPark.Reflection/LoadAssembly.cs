using System.Reflection;
using VirtualPark.ReflectionAbstractions;

namespace VirtualPark.Reflection;

public sealed class LoadAssembly<TInterface>(string path) : ILoadAssembly<TInterface>
    where TInterface : class
{
    private readonly DirectoryInfo _directory = new(path);
    private List<Type> _implementations = [];

    public List<string?> GetImplementations()
    {
        var result = new List<string?>();
        var files = _directory.GetFiles("*.dll");

        foreach (var file in files)
        {
            var assembly = Assembly.LoadFile(file.FullName);

            var types = assembly
                .GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && typeof(TInterface).IsAssignableFrom(t))
                .ToList();

            if (types.Count == 0)
            {
                throw new InvalidOperationException($"No strategies found in assembly '{file.Name}'.");
            }

            foreach (var type in types)
            {
                try
                {
                    var instance = Activator.CreateInstance(type) as IStrategy;
                    if (instance is null)
                    {
                        continue;
                    }

                    _implementations.Add(type);
                    result.Add(instance.Key);
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException(
                        $"Error instantiating '{type.FullName}' in '{file.Name}': {ex.Message}", ex);
                }
            }
        }

        return result
            .Where(k => !string.IsNullOrWhiteSpace(k))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    public TInterface GetImplementation(string assemblyName, params object[] args)
    {
        if (_implementations == null || _implementations.Count == 0)
        {
            throw new InvalidOperationException("No implementations loaded.");
        }

        var type = _implementations.FirstOrDefault(t =>
            string.Equals(t.Name, assemblyName, StringComparison.OrdinalIgnoreCase) ||
            string.Equals(t.FullName, assemblyName, StringComparison.OrdinalIgnoreCase));

        if (type == null)
        {
            throw new InvalidOperationException($"Implementation '{assemblyName}' not found among loaded assemblies.");
        }

        try
        {
            var instance = Activator.CreateInstance(type, args);
            return (TInterface)instance!;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to create instance of '{assemblyName}': {ex.Message}", ex);
        }
    }
}
