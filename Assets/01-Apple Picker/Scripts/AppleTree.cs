﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour{
    [Header("Set in Inspector")]
    
    public GameObject applePrefab;

    public float speed = 1f;

    public float leftandRightEdge = 10f;

    public float chancetoChangeDirections = 0.1f;

    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
