using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class changeMonster : MonoBehaviour
{
    public Button BUTTON;
    public Sprite[] IMAGES;
    private Sprite RANDOM;
    // Start is called before the first frame update
    void Start()
    {
        BUTTON = GetComponent<Button>();
        changeButton();
    }

    public void changeButton(){
        RANDOM = IMAGES[Random.Range(0, IMAGES.Length)];
        BUTTON.image.overrideSprite = RANDOM;
        BUTTON.enabled=false;
        Tareas.Nueva(3, disableButton);
    }

    public void disableButton(){
        BUTTON.enabled=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
