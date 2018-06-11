using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ReloadScene : MonoBehaviour {
    public void Reload()
    {
        SceneManager.LoadScene("testcar");
    }
}
