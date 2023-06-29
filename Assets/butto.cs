using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butto : MonoBehaviour
{
    bool A = false;
    public GameObject coco;

    public void showObject()
    {
        coco.SetActive(!coco.activeSelf);
    }
}
