using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gm : MonoBehaviour {


    public static float virtVel = 0;
    // Use this for initialization
    public static int CoinTotal = 0;
    public static float TimeTotal = 0;
    public static float zVelAdj = 1;
    public static bool LvlComplete = true;
    public float WaitToLoad = 0;
	void Start () {
        GetComponent<Rigidbody>().velocity = new Vector3(0, gm.virtVel, 0);
	}
	
	// Update is called once per frame
	void Update () {
        TimeTotal += Time.deltaTime;
        if (LvlComplete == false)
        {
            WaitToLoad += Time.deltaTime;
        }
        if(WaitToLoad>2)
        {
            SceneManager.LoadScene("LevelComp");
        }
	}
}
