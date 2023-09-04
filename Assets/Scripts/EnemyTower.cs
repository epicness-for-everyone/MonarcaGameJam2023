using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTower : MonoBehaviour
{
    [SerializeField][Range(1,7)] private float spawnTimer;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject Unit;
    [SerializeField] private List<GameObject> listUnits;

    private int sizeList= 10;
    private float countTimer;
    private int o;
    private void Awake(){

    }
    // Start is called before the first frame update
    void Start()
    {
        countTimer= 0;
        //AddUnitsPool(sizeList);
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

    public void RequestUnit(){
        for(o=0; o<listUnits.Count; o++){
            if(!listUnits[o].activeSelf){
                //listUnits[o].SetActive(true);
                //Objeto seleccionado
            }
        }
        AddUnitsPool(1);
        //listUnits[listUnits.Count - 1].SetActive(true);
        //Objeto sleecionado
    }
    public void SpawnUnit(){
        Instantiate(Unit, spawnPoint.position, Quaternion.identity);
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
