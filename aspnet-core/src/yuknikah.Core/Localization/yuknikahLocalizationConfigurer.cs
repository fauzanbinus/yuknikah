using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace yuknikah.Localization
{
    public static class yuknikahLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(yuknikahConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(yuknikahLocalizationConfigurer).GetAssembly(),
                        "yuknikah.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
