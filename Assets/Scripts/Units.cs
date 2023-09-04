using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour
{
    [SerializeField] private int life;
    [SerializeField] private int damage;
    [SerializeField][Range(0,3)] private float attackCooldown;
    [SerializeField] private float movementSpeed;
    [SerializeField][Range(-1,1)] private int direction;

    [SerializeField]private bool move= false;
    private Vector3 dmov;
    private void Awake(){}
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(move){
            dmov= new Vector3(direction * movementSpeed, 0, 0);
            transform.Translate(dmov * Time.deltaTime);
        }
    }

    public void TakeDamage(){

    }

    //getters and setters
    public void setMove(bool b){
        move= b;
    }
    public bool getMove(){
        return move;
    }
}
