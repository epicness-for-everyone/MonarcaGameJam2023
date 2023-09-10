using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDisable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DisableObject(){
        gameObject.SetActive(false);
    }
}
