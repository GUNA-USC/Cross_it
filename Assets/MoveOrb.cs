﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveOrb : MonoBehaviour
{
    public KeyCode moveLeft;
    public KeyCode moveRight;

    public float horizVel = 0;
    public float laneNum = 2;
    public bool controllocked = false;//Sync locker, to get rid of user's pressing rapidly.
    // Use this for initialization

    public Transform boomObj;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, gm.virtVel, 4);
        if (Input.GetKeyDown(moveLeft) && laneNum > 1 && !controllocked)
        {
            controllocked = true;
            horizVel = -2;//Set the speed = 2 and negative
            StartCoroutine(stopSlide());
            laneNum -= 1;
        }
        if (Input.GetKeyDown(moveRight) && laneNum < 3 && !controllocked)
        {
            controllocked = true;
            horizVel = 2;
            StartCoroutine(stopSlide());
            laneNum += 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ramptrigger")
        {
            gm.virtVel = 2;

        }
        if(other.gameObject.name == "ramptoptrigger")
        {
            gm.virtVel = 0;
        }
        //if(other.gameObject.tag == "Lethal")
        //{
        //    gm.virtVel = 0;
        //    Destroy(gameObject);
        //}
        if(other.gameObject.name == "Exit")
        {
            SceneManager.LoadScene("LevelComp");
        }
        if(other.gameObject.name =="Coin")
        {
            Destroy(other.gameObject);
            gm.CoinTotal++;
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Lethal")
        {
            Destroy(gameObject);
            gm.zVelAdj = 0;
            Instantiate(boomObj, transform.position, boomObj.rotation);
            gm.LvlComplete = false;
        }
        if(other.gameObject.name == "Capsule")
        {
            Destroy(other.gameObject);
        }
    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(0.5f);//hold the speed for 0.5 second;f for float; So distance is 2*0.5 = 1.
        horizVel = 0;//Set the speed back to zero.
        controllocked = false;
    }
}
