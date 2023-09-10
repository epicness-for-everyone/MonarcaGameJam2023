using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combineMonster : MonoBehaviour
{
    public string PIECE_SELECT;
    public string BODY_SELECT;
    public string gotMonster;
    // Start is called before the first frame update cambiar a mergeMonster
    void Start()
    {

    }

    public void mergeResult(){
        changeMonster piece = GetComponent<changeMonster>();
        PIECE_SELECT = piece.pieceSelect;

        changeMonster body = GetComponent<changeMonster>();
        BODY_SELECT = body.bodySelect;

        Debug.Log("merge "+PIECE_SELECT + BODY_SELECT);

        switch(PIECE_SELECT)
        {
            case "PIECE_0":
                switch(BODY_SELECT)
                {
                    case "BODY_0":
                        Debug.Log("PIECE_0  BODY_0"+" cycplop04_walk");
                    break;
                    default:
                        Debug.Log("PIECE_0  BODY_5");
                    break;
                }
            break;
            case "PIECE_1":
                switch(BODY_SELECT)
                {
                    case "BODY_0":
                        Debug.Log("PIECE_1  BODY_0"+" cycplop02_walk");
                    break;
                    default:
                        Debug.Log("PIECE_1  BODY_0");
                    break;
                }
            break;
            case "PIECE_2":
                switch(BODY_SELECT)
                {
                    case "BODY_0":
                        Debug.Log("PIECE_2  BODY_0"+" cycplop01_walk");
                    break;
                    default:
                        Debug.Log("PIECE_2  BODY_0");
                    break;
                }
            break;
            case "PIECE_3":
                switch(BODY_SELECT)
                {
                    case "BODY_0":
                        Debug.Log("PIECE_3  BODY_0"+" cycplop03_walk");
                    break;
                    default:
                        Debug.Log("PIECE_3  BODY_0");
                    break;
                }
            break;
            default:
                switch(BODY_SELECT)
                {
                    case "BODY_0":
                        Debug.Log("PIECE_0  BODY_0"+" cycplop00_walk");
                    break;
                    default:
                        Debug.Log("PIECE_0  BODY_0");
                    break;
                }
            break;
        }
    }

    // Update is called once per frame
    //void Update(){}

}
