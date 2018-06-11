using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour {
    public GameObject panel;
    private PlayerMotor motor;
   
    // Use this for initialization
    void Start () {
        panel.SetActive(false);
        motor = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
    }
	
	// Update is called once per frame
	void Update () {
        if (motor.IsGameOver())
        {
            panel.SetActive(true);
        }
	}
}
