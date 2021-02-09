﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {

    [Header(“Set Dynamically”)]
    public float camZ;

    void Awake(){
	camZ = this.transform.position.z;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        if (POI  == null) return;

        Vector3 destination = POI.transform.position;
        //Destination.x = Mathf.Max( minXY.x, destination.x );
        //Destination.y = Mathf.Max( minXY.y, destination.y );
        //Destination = Vector3.Lerp(transform.position, destination, easing);
        destination.z = camZ;
        transform.position = destination;
        //Camera.main.orthographicSize = destination.y + 10;
        }

}
