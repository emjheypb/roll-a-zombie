using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tile : MonoBehaviour {
    public GameManager gameManager;

    void OnTriggerEnter(Collider other) {
        gameManager.AddScore();
    }
}
