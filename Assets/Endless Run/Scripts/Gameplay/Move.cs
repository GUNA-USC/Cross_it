using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    int num = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -1.8)
        {
            num = 1;
        }
        if (transform.position.x > 1.8)
        {
            num = -1;
        }
        transform.Translate(Vector3.right * Time.deltaTime * num);
    }
}
