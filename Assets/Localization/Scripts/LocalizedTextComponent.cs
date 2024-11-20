using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class LocalizedTextComponent : MonoBehaviour
{
    [SerializeField] private string tableReference; //name of table
    [SerializeField] private string localizationKey; //key

    private LocalizedString localizedString; //holds key and reference <- translation is done here
    private Text textComponent; //text gonna localize

    // Start is called before the first frame update
    void Start()
    {
        textComponent = GetComponent<Text>();
        localizedString = new LocalizedString { TableReference = tableReference, TableEntryReference = localizationKey };
        LocalizationSettings.SelectedLocaleChanged += UpdateText;

        var frenchLocale = LocalizationSettings.AvailableLocales.GetLocale("fr");
        LocalizationSettings.SelectedLocale = frenchLocale;
        UpdateText(frenchLocale);
    }

    private void OnDestroy()
    {
        LocalizationSettings.SelectedLocaleChanged -= UpdateText;
    }

    void UpdateText(Locale locale)
    {
        textComponent.text = localizedString.GetLocalizedString();  // actual translation logic is here
    }
}
