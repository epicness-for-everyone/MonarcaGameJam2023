using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDefault : MonoBehaviour
{
    [SerializeField] private int life;
    [SerializeField] private int damage;
    [SerializeField][Range(-1,1)] private  int direcction;
    [SerializeField] private float speed;
    [SerializeField] [Range(0.1f,5f)] private float recoilDistance;
    [SerializeField] private float animations;
    // Start is called before the first frame update 

    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update(){}
    public int getLife(){
        return life;
    }
    public int getDamage(){
        return damage;
    }
    public int getDirection(){
        return direcction;
    }
    public float getSpeed(){
        return speed;
    }
    public float getRecoilDistance(){
        return recoilDistance;
    }
    public float getAnim(){
        return animations;
    }
}
