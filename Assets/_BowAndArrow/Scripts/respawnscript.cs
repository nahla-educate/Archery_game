using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnscript : MonoBehaviour
{
    [SerializeField] GameObject arrow;
    [SerializeField] Transform spawnPoint;
   
   // [SerializeField] float spawnValue;
    [SerializeField] GameObject terrain;

    


    private void OnCollisionEnter(Collision collision)
    {   
        print(collision.gameObject.name);
        if(collision.gameObject.name == "Plane" || collision.gameObject.name =="Terrain" )
        {
            RespawnPoint();
            


        }

    }

    // Update is called once per frame

   
    public void RespawnPoint()
    {
        transform.position = spawnPoint.position;
        GetComponent<Rigidbody>().velocity= Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        transform.localRotation = Quaternion.Euler(0, 0, 0);
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Rigidbody>().useGravity = false;


    }
}
