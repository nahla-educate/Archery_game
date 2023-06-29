using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oncollisionwithtarget : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name== "Arrow")
        {
            print("collision detected");
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
