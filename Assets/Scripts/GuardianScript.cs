using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardianScript : MonoBehaviour {

    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private Sprite whip, extendedWhip;

    void Start() {

    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.K)) {
            sprite.sprite = extendedWhip;
        }
        if (Input.GetKeyUp(KeyCode.K)) {
            sprite.sprite = whip;
        }
    }
}
