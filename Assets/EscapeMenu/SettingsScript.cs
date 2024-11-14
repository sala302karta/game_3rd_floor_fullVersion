using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    public Dictionary<string, object> settings = new Dictionary<string, object>();
    public void SaveSettings()
    {
        SettingsElement[] settingsElements = GetComponentsInChildren<SettingsElement>();
        foreach (var setting in settingsElements)
        {
            settings[setting.key] = setting.value;
        }   
    }
}
