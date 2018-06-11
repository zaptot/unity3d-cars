using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {
    private int direction = 1;
    private bool IsRunnig = false;
    private bool GameOver = false;
    private AudioListener motorListener;

    public AudioSource breakCar;
	// Use this for initialization
	void Start () {
        motorListener = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioListener>();
    }
	
	// Update is called once per frame
	void Update () {
	}
    public void changeDir()
    {
        direction *= -1;
    }
    void OnTriggerEnter(Collider a)
    {
        if (!a.CompareTag("saver"))
        {
            breakCar.Play();
            GameOver = true;
        }
    }

    public void StartGame()
    {
        IsRunnig = true;
    }

    public bool IsStarted()
    {
        return IsRunnig;
    }

    public bool IsLeft()
    {
        return direction == -1 ? true : false;
    }
    public bool IsGameOver()
    {
        return GameOver;
    }

    public int Direction()
    {
        return direction;
    }

}
