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
    public Sprite[] PIECE_MONSTER;
    public Sprite[] BODY_MONSTER;
    private Sprite RANDOM;
    private Sprite RANDOM2;
    public string pieceSelect;
    public string bodySelect;
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
        MCPM1_IMG.sprite = PIECE_MONSTER[Random.Range(0, PIECE_MONSTER.Length)];
        MCPM2_IMG.sprite = PIECE_MONSTER[Random.Range(0, PIECE_MONSTER.Length)];
        MCCM_IMG.sprite = BODY_MONSTER[Random.Range(0, BODY_MONSTER.Length)];
    }

    public void changeButton(string select){
        if(select == "MCPM1") pieceSelect = MCPM1_IMG.sprite.name;
        else pieceSelect = MCPM2_IMG.sprite.name;
        bodySelect =  MCCM_IMG.sprite.name;
        
        RANDOM = PIECE_MONSTER[Random.Range(0, PIECE_MONSTER.Length)];
        RANDOM2 = PIECE_MONSTER[Random.Range(0, PIECE_MONSTER.Length)];
        MCPM1_IMG.sprite = RANDOM;
        MCPM2_IMG.sprite = RANDOM2;
        MCCM_IMG.sprite = BODY_MONSTER[Random.Range(0, BODY_MONSTER.Length)];
        MCPM1_BTN.enabled=false;
        MCPM2_BTN.enabled=false;
        //incluir función para combinar -merge-
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
