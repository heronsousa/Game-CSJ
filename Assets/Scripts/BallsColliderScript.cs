using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsColliderScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Point") {

        }

        if(collision.gameObject.tag == "Platform") {

        }
    }
}
