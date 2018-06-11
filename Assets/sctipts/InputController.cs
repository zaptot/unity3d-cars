using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    public GameObject car;
    public GameObject anim;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            if (!car.GetComponent<PlayerMotor>().IsStarted())
            {
                car.GetComponent<PlayerMotor>().StartGame();
                anim.GetComponent<AnimatorManager>().startFirst();
            }
            car.GetComponent<PlayerMotor>().changeDir();
            anim.GetComponent<AnimatorManager>().startAnim();
        }
	}
}
