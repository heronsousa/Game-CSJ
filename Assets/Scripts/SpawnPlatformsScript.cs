using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatformsScript : MonoBehaviour {

    public GameObject platformPrefab;
    public float tempoMin;
    public float tempoMax;
    float tempo;
    float tempoTotal;

    // Start is called before the first frame update
    void Start() {
        tempoTotal = Random.Range(tempoMin, tempoMax);
    }

    // Update is called once per frame
    void Update() {
        tempo += Time.deltaTime;

        if(tempo >= tempoTotal) {
            Instantiate(platformPrefab, transform.position, transform.rotation);
            tempo = 0f;
            tempoTotal = Random.Range(tempoMin, tempoMax);
        }    
    }
}
