﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A) == true)
        {
            transform.position = transform.position + (new Vector3(-Speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.position = transform.position + (new Vector3(Speed * Time.deltaTime, 0));
        }
    }
}
