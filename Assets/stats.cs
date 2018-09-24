using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(gameObject.name == "Coins")
        {
            GetComponent<TextMesh>().text = "Coins: " + gm.CoinTotal;
        }
        if(gameObject.name == "Time")
        {
            GetComponent<TextMesh>().text = "Time:" + gm.TimeTotal;
        }
        if(gameObject.name == "Status")
        {
            if (gm.LvlComplete ==false)
            {
                GetComponent<TextMesh>().text = "Failed!";
            }
            else
            {
                GetComponent<TextMesh>().text = "Success!";
            }

        }
	}
}
