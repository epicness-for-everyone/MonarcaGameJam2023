using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    [SerializeField][Range(0f,1f)] private float lifePoint;
    private float maximunLife;
    private Transform ObjMask;
    private void Awake(){
        ObjMask= gameObject.transform.GetChild(0).gameObject.GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        lifePoint= 1f;
    }

    // Update is called once per frame
    void Update()
    {
        ObjMask.position= new Vector3((lifePoint*2)+transform.position.x, transform.position.y, transform.position.z);
    }

    public void ChangeLife(float nlife){
        lifePoint= nlife;
    }
    public void TakingDamage(int n){
        ChangeLife(((maximunLife-n)*maximunLife)/100);
    }
    public void MaxLife(float l){
        maximunLife= l;
        ChangeLife(1);
    }
}
