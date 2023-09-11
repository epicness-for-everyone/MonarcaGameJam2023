using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemys : MonoBehaviour
{
    [SerializeField] private Towers EnemyTower;
    [SerializeField][Range(1f,5f)] private float spawnTimer;
    private float countTimer;
    [SerializeField] private List<GameObject> Enemys;
    private void Awake(){
        for(int i=0; i<transform.childCount; i++){
            Enemys.Add(transform.GetChild(i).gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countTimer+= Time.deltaTime;
        if(countTimer >= spawnTimer){
            EnemyTower.SpawnUnit(Enemys[Random.Range(0,Enemys.Count)]);
            countTimer= 0;
        }
    }
}
