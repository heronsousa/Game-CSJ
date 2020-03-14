using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsScript : MonoBehaviour {

    public float speed;
    public bool right;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            right = !right;
        }

        if(right) {
            transform.Rotate(new Vector3(0f, 0f, speed * Time.deltaTime));
        } else {
            transform.Rotate(new Vector3(0f, 0f, -speed * Time.deltaTime));
        }

    }
}
