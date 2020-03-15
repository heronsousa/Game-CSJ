using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointBarScript : MonoBehaviour {
    
    public float speed = -1;

    // Update is called once per frame
    void Update() {
        transform.Translate(new Vector2(0f, speed * Time.deltaTime));
    }
}
