﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed = 10f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();   	
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    // FixedUpdate is called once before any physics Calculation
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
    
}
