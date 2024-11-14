using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SettingsElement : MonoBehaviour
{
    public string key;
    public object value;

    private void Start()
    {
        SettingsScript script = GetComponentInParent<SettingsScript>();
        value = script.settings.GetValueOrDefault(key);
        var slider = GetComponent<UnityEngine.UI.Slider>();
        if (slider != null)
        {
            if (value != null && value is float)
            {
                slider.value = (float) value;
            }
            slider.onValueChanged.AddListener((newValue) => { value = newValue; });
        }
    }
}
