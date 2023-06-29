using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreCalcul : MonoBehaviour
{

    public TMP_Text sc;
    float score = 0;

    void OnCollisionEnter(Collision other)
    {


        print(other.gameObject.name);


        if (other.gameObject.name == "Cylinder.002")
        {

            score += 10;
            print("CylindreBlueGhame9");
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Rigidbody>().velocity = Vector3.zero;

        }

        if (other.gameObject.name == "Cylinder.004")
        {

            score += 10;
            print("CylinderRed");
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Rigidbody>().velocity = Vector3.zero;








        }
        if (other.gameObject.name == "Cylinder")
        {

            score += 10;
            print("CylinderYellow");
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Rigidbody>().velocity = Vector3.zero;

        }
        if (other.gameObject.name == "Cylinder.001")
        {


            score += 10;

            print("CylinderWhite");
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Rigidbody>().velocity = Vector3.zero;

        }
        if (other.gameObject.name == "Cylinder.003")
        {


            score += 10;

            print("CylinderBlueFate7");
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Rigidbody>().velocity = Vector3.zero;


        }
        sc.text = score.ToString();

    }
    void Start()
    {
        sc.text = score.ToString();

    }
}