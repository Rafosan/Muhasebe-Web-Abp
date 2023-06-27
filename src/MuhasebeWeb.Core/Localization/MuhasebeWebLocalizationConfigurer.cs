using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MuhasebeWeb.Localization
{
    public static class MuhasebeWebLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MuhasebeWebConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MuhasebeWebLocalizationConfigurer).GetAssembly(),
                        "MuhasebeWeb.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
