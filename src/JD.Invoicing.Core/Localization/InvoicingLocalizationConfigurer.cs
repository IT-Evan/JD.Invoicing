using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace JD.Invoicing.Localization
{
    public static class InvoicingLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(InvoicingConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(InvoicingLocalizationConfigurer).GetAssembly(),
                        "JD.Invoicing.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
