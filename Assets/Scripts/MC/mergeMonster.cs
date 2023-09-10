using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mergeMonster : MonoBehaviour
{
    [SerializeField] private Towers MonsterTower;
    public string PIECE_SELECT;
    public string BODY_SELECT;
    [SerializeField] private List<GameObject> Monsters;
    private void Awake(){
        for(int i=0; i<transform.childCount; i++){
            Monsters.Add(transform.GetChild(i).gameObject);
        }
    }
    //public string gotMonster;
    // Start is called before the first frame update cambiar a mergeMonster
    void Start()
    {

    }

    public void mergeResult(string piece, string body){
        PIECE_SELECT= piece;
        BODY_SELECT = body;

        //Debug.Log("merge "+PIECE_SELECT + BODY_SELECT);

        switch(PIECE_SELECT)
        {
            case "PIECE_0":
                switch(BODY_SELECT)
                {
                    case "BODY_0":
                        MonsterTower.SpawnUnit(Monsters[4]);
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
                        MonsterTower.SpawnUnit(Monsters[2]);
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
                        MonsterTower.SpawnUnit(Monsters[1]);
                        Debug.Log("PIECE_2  BODY_0 "+" cycplop01_walk");
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
                        MonsterTower.SpawnUnit(Monsters[3]);
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
                        MonsterTower.SpawnUnit(Monsters[0]);
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
