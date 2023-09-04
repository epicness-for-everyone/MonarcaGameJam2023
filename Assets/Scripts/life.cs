using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    [SerializeField][Range(0f,1f)] private float lifePoint;
    [SerializeField] private Transform ObjMask;
    // Start is called before the first frame update
    void Start()
    {
        lifePoint= 1f;
    }

    // Update is called once per frame
    void Update()
    {
        ObjMask.position= new Vector3(lifePoint+transform.position.x, transform.position.y, transform.position.z);
    }
}
