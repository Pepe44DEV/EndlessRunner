using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DethScore : MonoBehaviour
{
    Text Score;   


    void Start(){
        Score = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update(){
        Score.text = "Score: " + ScoreScript.scoreValue;

    }
}
