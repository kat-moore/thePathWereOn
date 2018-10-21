using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterColliderController : MonoBehaviour {

    public float speed;
    Vector3 target = new Vector3(-120, 4, -11);
    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }
}


