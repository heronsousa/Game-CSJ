using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsColliderScript : MonoBehaviour{

    public BallsScript count;

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Point") {
            Destroy(collision.gameObject);
            count.UpdateScore();
        }

        if(collision.gameObject.tag == "Platform") {
            count.GameOver();
        }
    }
}
