using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VersionDisplay : MonoBehaviour
{
    [SerializeField] private string currentVersion;
    [SerializeField] private TextMeshProUGUI versionTextDisplay;

    public void Awake(){
      getCurrentVersion();
      updateVersionTextDisplay();
    }

    private void getCurrentVersion(){
      currentVersion = Application.version;
    }

    private void updateVersionTextDisplay(){
      versionTextDisplay.text = "Ver: " + currentVersion;
    }

}
