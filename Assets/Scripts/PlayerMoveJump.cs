using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveJump : MonoBehaviour{

    public float jumpForce = 5f;
    public float forwardForce = 0f;

    private Rigidbody2D myRB;
    private bool canJump;

    void Start(){
        myRB = GetComponent<Rigidbody2D> ();
        
    }

    //Jump Funktion
    public void Jump(){

        if (canJump){

            canJump = false;
             
            if(transform.position.x < 0){
                forwardForce = 1f;


            }
            else{
                forwardForce = 0f;


            }


            myRB.velocity = new Vector2(forwardForce, jumpForce);

        }
  
    }

    private void OnCollisionEnter2D(Collision2D other){
        canJump = true;
        
    }

}
