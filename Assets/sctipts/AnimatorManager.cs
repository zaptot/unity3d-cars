using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour {
    public GameObject car;
    private PlayerMotor motor;
    // Use this for initialization
    void Start() {
        motor = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update() {

    }

    public void startFirst()
    {
        car.GetComponent<Animator>().SetBool("is_started", true);
    }

    public void startAnim()
    {
        if (!car.GetComponent<PlayerMotor>().IsGameOver() && car.GetComponent<PlayerMotor>().IsStarted())
        {
            if (car.GetComponent<PlayerMotor>().IsLeft())
            {
                car.GetComponent<Animator>().SetBool("is_left", true);
            }
            else
            {
                car.GetComponent<Animator>().SetBool("is_left", false);
            }
        }
    }
}
