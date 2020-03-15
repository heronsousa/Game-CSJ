using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsScript : MonoBehaviour {

    public float speed = 250f;
    public bool right;

    public GameObject gameOver;
    public int score = 0;

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

    public void GameOver() {
        gameOver.SetActive(true);
    }

    public void UpdateScore() {
        score++;
    }
}
