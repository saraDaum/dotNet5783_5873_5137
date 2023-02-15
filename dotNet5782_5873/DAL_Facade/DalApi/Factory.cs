namespace DalApi;
using System.Reflection;
using static DalApi.DalConfig;

public static class Factory
{
    public static IDal? Get()
    {
        string dalType = s_dalName
            ?? throw new DalConfigException($"DAL name is not extracted from the configuration");
        string dal = s_dalPackages[dalType]
           ?? throw new DalConfigException($"Package for {dalType} is not found in packages list");

        try
        {
            Assembly.Load(dal ?? throw new DalConfigException($"Package {dal} is null"));//Load DalList.dll file
        }
        catch (Exception)
        {
            throw new DalConfigException("Failed to load {dal}.dll package");
        }

        Type? type = Type.GetType($"Dal.{dal}, {dal}")//Returns metadata of Dal.DalList
            ?? throw new DalConfigException($"Class Dal.{dal} was not found in {dal}.dll");

        return type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?//Returns metadata of Instance
                   .GetValue(null) as IDal //Returns metadata of Instance that must be a single instance of DalList class (SingleTone)
            ?? throw new DalConfigException($"Class {dal} is not singleton or Instance property not found");
    }
}
