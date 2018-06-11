using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCar : MonoBehaviour {

    public AudioSource brrrr;
    private PlayerMotor motor;
	// Use this for initialization
	void Start () {
        motor = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
    }
	
	// Update is called once per frame
	void Update () {
        if (motor.IsGameOver())
        {
            brrrr.mute = true;
        }
	}
}
