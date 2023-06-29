using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecoloroncoll : MonoBehaviour
{
    bool blue;
    bool green;
    bool red;
    bool yellow;
    int counter;
    public Rigidbody arr;
    void Start()
    {
        blue = true;
    }
    void Update()
    {
        if (blue == true)
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        if (green == true)
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        if (yellow == true)
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        if (red == true)
            gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    void OnCollisionEnter()
    { //arr.isKinematic = true;
        //arr.transform.localPosition = transform.position;
       
        
        if (counter == 0)
        {

            blue = false;
            green = true;
            counter = 1;
        }
        else if (counter == 1)
        {
            green = false;
            yellow = true;
            counter = 2;
        }
        else if (counter == 2)
        {
            yellow = false;
            red = true;
            counter = 3;
        }
        else if (counter == 3)
        {
            red = false;
            blue = true;
            counter = 0;
        }
    }

}

