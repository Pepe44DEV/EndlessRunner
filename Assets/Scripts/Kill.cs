using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Kill"))
        {
            SceneManager.LoadScene("Deth");
            print("Debug");




        }

    }

   
}
