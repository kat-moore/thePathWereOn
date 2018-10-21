﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour {

    // Target marker
    //public Transform target;

    // Speed in units per sec
    public float speed;
    Vector3 target = new Vector3(-169, 5, -12);
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target, step);
	}
}
