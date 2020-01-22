﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        //Höhe Berechnen
        float height = Camera.main.orthographicSize * 2f;
        //Breite Berechnen
        float width = height * Screen.width / Screen.height;

        //GameObject (Bavkground) Skalieren


        if (gameObject.name == "Background")
        {
            transform.localScale = new Vector3(width, height, 0);

        }
        else
            transform.localScale = new Vector3(width, 2, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
