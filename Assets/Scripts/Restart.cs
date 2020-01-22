using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnRestarButtonClick()
    {

        SceneManager.LoadScene("Level 01");
        ScoreScript.scoreValue = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
