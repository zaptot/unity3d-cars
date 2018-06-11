using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonsController : MonoBehaviour {

    // Use this for initialization
    public Toggle shadows;

    public void Reload()
    {
        SceneManager.LoadScene("testcar");
    }
    public void ToggleShadowsCheckbox()
    {
        if (QualitySettings.shadows.ToString() == "HardOnly")
        {
            shadows.isOn = true;
        }
        else
        {
            shadows.isOn = false;
        }
        PlayerPrefs.Save();
    }

    public void CheckToggle()
    {
        if (shadows.isOn)
        {
            PlayerPrefs.SetInt("Shadows", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Shadows", 0);
        }
    }
}
