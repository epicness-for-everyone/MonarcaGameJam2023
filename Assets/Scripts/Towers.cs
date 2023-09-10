using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour
{
    [Header("Valores de la torre")]
    [SerializeField] private int life;
    [SerializeField][Range(1,7)] private float spawnTimer;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject Unit;
    [SerializeField] private List<GameObject> listUnits;

    [Header("Valores de las unidades")]

    private Units ctrUnits;
    
    

    private int sizeList= 5;
    private float countTimer;
    private int o;
    private GameObject ObjUnit;
    private void Awake(){

    }
    // Start is called before the first frame update
    void Start()
    {
        countTimer= 0;
        AddUnitsPool(sizeList);
    }

    // Update is called once per frame
    void Update()
    {
        countTimer+= Time.deltaTime;
        if(countTimer >= spawnTimer){
            SpawnUnit();
            countTimer= 0;
        }
    }

    
    public void SpawnUnit(){
        //Generar unidades
        //Instantiate(Unit, spawnPoint.position, Quaternion.identity);
        ObjUnit= RequestUnit();
        ObjUnit.SetActive(true);
        ObjUnit.transform.position= spawnPoint.position;
        ctrUnits= ObjUnit.GetComponent<Units>();
        ctrUnits.setMove(true);
        /*
        ObjUnit= RequestUnit();
        ObjUnit.SetActive(true);
        //transformcación
        ctrUnits= ObjUnit.GetComponent<Units>();
        ctrUnits.ResetUnit(int nlife, int ndamage, int ndir, float speed, float nrecoilD);
        */
    }
    public void TakeDamage(int damage){
        //La torre recibe daño
        life-= damage; 
    }
    public GameObject RequestUnit(){
        for(o=0; o<listUnits.Count; o++){
            if(!listUnits[o].activeSelf){
                return listUnits[o];
            }
        }
        AddUnitsPool(1);
        return listUnits[listUnits.Count -1];
    }
    private void AddUnitsPool(int n){
        //Crea n cantidad de objetos desactivandolos y añadiendolos a la lista
        for(int i=0; i<n; i++){
            GameObject obj= Instantiate(Unit);
            obj.SetActive(false);
            listUnits.Add(obj);
            obj.transform.parent= transform;
        }
    }
}
