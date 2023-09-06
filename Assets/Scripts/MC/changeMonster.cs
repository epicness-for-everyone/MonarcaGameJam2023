using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(Button))]

public class changeMonster : MonoBehaviour
{
    public GameObject MCPM1;
    public GameObject MCPM2;
    public GameObject MCCM;
    private Image MCPM1_IMG, MCPM2_IMG, MCCM_IMG;
    private Button MCPM1_BTN, MCPM2_BTN;
    public Sprite[] PIECE_IMAGES;
    public Sprite[] BODY_IMAGES;
    private Sprite RANDOM;
    private Sprite RANDOM2;
    public string PIECE_SELECT;
    public string BODY_SELECT;
    private void Awake(){
        MCPM1_IMG= MCPM1.GetComponent<Image>();
        MCPM2_IMG= MCPM2.GetComponent<Image>();
        MCCM_IMG = MCCM.GetComponent<Image>();
        MCPM1_BTN = MCPM1.GetComponent<Button>();
        MCPM2_BTN = MCPM2.GetComponent<Button>();
    }
    // Start is called before the first frame update
    void Start()
    {
        MCPM1_IMG.sprite = PIECE_IMAGES[Random.Range(0, PIECE_IMAGES.Length)];
        MCPM2_IMG.sprite = PIECE_IMAGES[Random.Range(0, PIECE_IMAGES.Length)];
        MCCM_IMG.sprite = BODY_IMAGES[Random.Range(0, BODY_IMAGES.Length)];
    }

    public void changeButton(string select){
        if(select == "MCPM1") PIECE_SELECT = MCPM1_IMG.sprite.name;
        else PIECE_SELECT = MCPM2_IMG.sprite.name;
        BODY_SELECT =  MCCM_IMG.sprite.name;
        Debug.Log("Selec "+ select + PIECE_SELECT + BODY_SELECT);
        
        RANDOM = PIECE_IMAGES[Random.Range(0, PIECE_IMAGES.Length)];
        RANDOM2 = PIECE_IMAGES[Random.Range(0, PIECE_IMAGES.Length)];
        MCPM1_IMG.sprite = RANDOM;
        MCPM2_IMG.sprite = RANDOM2;
        MCCM_IMG.sprite = BODY_IMAGES[Random.Range(0, BODY_IMAGES.Length)];
        MCPM1_BTN.enabled=false;
        MCPM2_BTN.enabled=false;
        Tareas.Nueva(3, disableButton);
    }
    

    public void disableButton(){
        MCPM1_BTN.enabled=true;
        MCPM2_BTN.enabled=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
