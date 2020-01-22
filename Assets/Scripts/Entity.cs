﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public float speed = -1f;
    private Rigidbody2D myRB;
    
    void Start(){
        myRB = GetComponent<Rigidbody2D>();


        
    }

   
    void Update(){
        myRB.velocity = new Vector2(speed, 0);
        
    }
}
