﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newcode : MonoBehaviour
{
    public int intel = 5;
    public bool HitOnHead = true;
    float test() 
    {
        return 5.0f; 
    }

    void Greet()
    {
        switch (intel) {
            case 5:
                print("Hello, good sir! Do you l,ike physics?");
                if (HitOnHead)
                {
                    intel = 4;
                    Greet();
                    HitOnHead = false;
                }
                break;

            case 4:
                print("xxx");
                break;

            case 3:
                print("xxx");
                break;

            case 2:
                print("xxx");
                break;

            case 1:
                print("xxx");
                break;

            default:
                print("??");
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            intel++;
        }
        else if (Input.GetKeyDown(KeyCode.Space)){
            intel--;
        }
    }
}
