using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowsController : MonoBehaviour {

    // Use this for initialization
    void Start() {
        if (PlayerPrefs.GetInt("Shadows") == 1)
        {
            QualitySettings.shadows = ShadowQuality.HardOnly;
        }
        else
        {
            QualitySettings.shadows = ShadowQuality.Disable;
        }
    }
}
