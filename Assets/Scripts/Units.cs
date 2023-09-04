using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour
{
    [SerializeField] private int life;
    [SerializeField] private int damage;
    [SerializeField] private float movementSpeed;
    [SerializeField] private Vector2 direction;

    private bool move;
    private Vector3 dmov;
    // Start is called before the first frame update
    void Start()
    {
        move=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(move){
            dmov= new Vector3(direction.x + movementSpeed, direction.y, 0);
            transform.Translate(direction * Time.deltaTime);
        }
    }

    //getters and setters
    public void setMove(bool b){
        move= b;
    }
    public bool getMove(){
        return move;
    }
}
