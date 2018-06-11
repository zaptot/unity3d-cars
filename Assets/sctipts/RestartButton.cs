using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartButton : MonoBehaviour {

    public GameObject restart;

    public void Reload()
    {
        SceneManager.LoadScene("testcar");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
