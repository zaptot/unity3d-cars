using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

    public GameObject[] cars;
    public GameObject[] spawners;
    private PlayerMotor motor;
    private UpdTerrs terrsMover;
    private int countOfSpawns;
    public GameObject spawnController;
    // Use this for initialization
    void Start () {
        terrsMover = GameObject.FindGameObjectWithTag("GameController").GetComponent<UpdTerrs>();
        motor = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
        StartCoroutine(Inst());
	}
	
	// Update is called once per frame
	void Update () {
        if (motor.IsStarted() && !motor.IsGameOver())
        {
            spawnController.transform.Translate(new Vector3(terrsMover.GetKoef(), 0, 0) * Time.deltaTime);
        }
	}

    IEnumerator Inst()
    {
        if (motor.IsStarted() && !motor.IsGameOver())
        {
            yield return new WaitForSeconds(1);
            countOfSpawns = (int)(Random.value * 2) + 2;
            for(int i = 0; i < countOfSpawns; i++)
            {
                GameObject ob = Instantiate(cars[(int)(Random.value * 4)], spawners[(int)(Random.value * 4)].transform) as GameObject;
            }
        }
        else
        {
            yield return new WaitForSeconds(0);
        }
        Updater();
    }

    void Updater()
    {
        StartCoroutine(Inst());
    }
}
