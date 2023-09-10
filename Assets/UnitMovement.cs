using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMovement : MonoBehaviour {

    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] animationFrames;
    private float time;
    [SerializeField] private float animationDuration;
    // Start is called before the first frame update
    void Start() {
        time = 0f;
    }

    // Update is called once per frame
    void Update() {
        time += Time.deltaTime;

        float index = scale(0f, animationDuration, 0, animationFrames.Length - 1, time);
        index = Mathf.Min(index, animationFrames.Length - 1);
        spriteRenderer.sprite = animationFrames[(int)index];
        if (time >= animationDuration) {
            time = 0f;
        }
    }

    public float scale(float OldMin, float OldMax, float NewMin, float NewMax, float OldValue) {

        float OldRange = (OldMax - OldMin);
        float NewRange = (NewMax - NewMin);
        float NewValue = (((OldValue - OldMin) * NewRange) / OldRange) + NewMin;

        return (NewValue);
    }
}
