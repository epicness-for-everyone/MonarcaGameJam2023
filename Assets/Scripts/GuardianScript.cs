using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardianScript : MonoBehaviour {

    [SerializeField] private AudioSource whipAudio;
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private Sprite whip, extendedWhip;

    void Start() {

    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.K)) {
            sprite.sprite = extendedWhip;
            sprite.transform.Translate(new Vector3(0.3f, 0f, 0f));
            whipAudio.Play();
        }
        if (Input.GetKeyUp(KeyCode.K)) {
            sprite.sprite = whip;
            sprite.transform.Translate(new Vector3(-0.3f, 0f, 0f));
        }
    }
}
