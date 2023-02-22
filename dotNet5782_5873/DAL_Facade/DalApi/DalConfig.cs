using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi;
using System.Xml.Linq;

static class DalConfig
{
    internal static string? s_dalName;
    internal static Dictionary<string, string> s_dalPackages;

    static DalConfig()
    {
        XElement dalConfig = XElement.Load(@"..\xml\dal-config.xml")//Loads XML file and do parsing
            ?? throw new DalConfigException("dal-config.xml file is not found");
        s_dalName = dalConfig?.Element("dal")?.Value
            ?? throw new DalConfigException("<dal> element is missing");
        var packages = dalConfig?.Element("dal-packages")?.Elements()//Returns all sub-elements of dal-packages
            ?? throw new DalConfigException("<dal-packages> element is missing");
        s_dalPackages = packages.ToDictionary(p => "" + p.Name, p => p.Value);//Returns hash table that name= hashKey and value=the value that attached to hahsKey
    }
}
