using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class TowerScript : MonoBehaviour {

    [SerializeField] private GameObject guardian;
    private float healTimer;
    // Start is called before the first frame update
    void Start() {
        healTimer = 0f;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.N)) {
            if (guardian == null) {
                Debug.Log("Guardian is null");
            } else {
                Destroy(guardian);
                Debug.Log("Guardian wasn't null, but now it is");
            }
        }
        if (guardian != null) {
            healTimer += Time.deltaTime;
            if (healTimer > 180f) {
                Debug.Log("Healing tower to max HP");
                healTimer = 0f;
            }
        }
    }
}
