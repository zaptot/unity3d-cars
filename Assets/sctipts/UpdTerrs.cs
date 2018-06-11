using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdTerrs : MonoBehaviour {

    public GameObject First;
    public GameObject Second;
    public GameObject Third;
    private GameObject[] AllTerrs;
    public float movespeed = 1.0f;
    private PlayerMotor motor;
    private float koef = 3.0f;
 
    public void swap(ref GameObject left, ref GameObject right)
    {
        GameObject tmp = left;
        left = right;
        right = tmp;
    }

    void Start () {
        if (PlayerPrefs.GetInt("Shadows") == 1)
        {
            QualitySettings.shadows = ShadowQuality.All;
        }
        else
        {
            QualitySettings.shadows = ShadowQuality.Disable;
        }
        motor = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMotor>();
        AllTerrs = new GameObject[3];
        AllTerrs[0] = First;
        AllTerrs[1] = Second;
        AllTerrs[2] = Third;
	}

    // Update is called once per frame
    void Update() {
        if (motor.IsStarted() && !motor.IsGameOver())
        {
            if (AllTerrs[0].transform.position.z < -AllTerrs[0].transform.localScale.z * 5)
            {
                swap(ref AllTerrs[0], ref AllTerrs[2]);
                swap(ref AllTerrs[1], ref AllTerrs[0]);
                AllTerrs[2].transform.SetPositionAndRotation(new Vector3(AllTerrs[1].transform.localPosition.x, 0, AllTerrs[1].transform.localPosition.z + AllTerrs[1].transform.localScale.z * 10), Quaternion.identity);
            }
            for (int i = 0; i < AllTerrs.Length; i++)
            {
                AllTerrs[i].transform.Translate(new Vector3(GetKoef(), 0, -movespeed) * Time.deltaTime);
            }
        }
	}

    public float GetKoef()
    {
        return -motor.Direction()* koef;
    }
}
