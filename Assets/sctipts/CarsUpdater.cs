using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsUpdater : MonoBehaviour {

    private float movespeed;
    private UpdTerrs terrsMover;
    public GameObject car;
    private PlayerMotor motor;
    private float minSpeed;
    private GameObject changer;
    public AudioSource curAudio;
    // Use this for initialization
    void Start () {
        minSpeed = 5;
        terrsMover = GameObject.FindGameObjectWithTag("GameController").GetComponent<UpdTerrs>();
        motor = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
        movespeed = Random.value * 2 + 3;
	}
	
	// Update is called once per frame
	void Update () {
        if(car.transform.position.z > 0 && !motor.IsGameOver())
        {
            car.transform.Translate(new Vector3(0, 0, -movespeed) * Time.deltaTime);
        }
        else if(car.transform.position.z < 0)
        {
            Destroy(car);
        }
        if (motor.IsGameOver())
        {
            curAudio.mute = true;
        }
	}

    void OnTriggerEnter(Collider a)
    {
        if (a.CompareTag("saver"))
        {
            a.gameObject.GetComponentInParent<CarsUpdater>().SpeedUp();
            movespeed = minSpeed;
        }
    }
    void SpeedUp()
    {
        movespeed--;
    }
}
