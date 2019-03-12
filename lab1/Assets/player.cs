﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletsSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        //other way to move the player
        transform.Rotate(0,x,0);
        transform.Translate(0,0,z);

        if (Input.GetKeyDown(KeyCode.Space)) {
            Fire();
        }
    }

    void Fire() {

        var newbullet = (GameObject)Instantiate(
            bullet,
            bulletsSpawn.position,
            bulletsSpawn.rotation);

        //add velocity to the bullet
        newbullet.GetComponent<Rigidbody>().velocity = newbullet.transform.forward * 20;

        //Destory
        Destroy(newbullet, 2.0f);
    }
}