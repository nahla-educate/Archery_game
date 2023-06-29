using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Microsoft.MixedReality.Toolkit.Utilities;



public class Firearrow : MonoBehaviour
{

    public Rigidbody arr;
    public GameObject bow;
    public GameObject initpos;
    public GameObject dir;
   

    private const float PinchThreshold = 0.7f;
    [SerializeField] private Handedness trackedHand = Handedness.Both;
    public static bool flag = false;
    public static bool flagg = true;
    public float timer = 2.0f;
    
    // Start is called before the first frame update

    // Update is called once per frame
    Vector3 startPosition;

    void Start()
    {

        print("start" + flag);
        startPosition = transform.position;

    }

    void Update()
    {
        Vector3 direction = arr.transform.position - dir.transform.position;
        Vector3 newvector =direction.normalized;
                

        if (IsPinching(trackedHand))
        {
            flag = true;
            timer = 2.0f;

        }




        if (!IsPinching(trackedHand) && flag && initpos.transform.position != transform.position)
        {
            print("shoot");
            
            
            
           
            
            


            //Launch arrow.




            arr.GetComponent<Rigidbody>().isKinematic = false;
                arr.GetComponent<Rigidbody>().useGravity = true;
            //speed = speed * Time.fixedDeltaTime;
            
                print(Time.fixedDeltaTime);
                print(direction);
                print(arr.transform.localPosition);
                print(dir.transform.localPosition);


                float distance1 = Vector3.Distance(arr.transform.position, bow.transform.position);
            if (distance1 < 0) { arr.velocity = newvector * 0.0f; }
            else if( distance1>0.022f && distance1 < 0.03f)
            { arr.velocity = newvector * -3.0f; }
            else if(distance1 > 0.03f && distance1 < 0.05f)
            {
                arr.velocity = newvector * -7.0f;

            }
            else if (distance1 > 0.05f && distance1 < 0.075f)
            {
                arr.velocity = newvector * -13.0f;
            }
            else if(distance1 > 0.075f && distance1 < 0.12f)
            {
                arr.velocity = newvector * -15.0f;
            }
            else if(distance1 > 0.12f && distance1 < 0.18f)
            {
                arr.velocity = newvector * -19.0f;
            }
            else if (distance1 > 0.18f && distance1 < 0.25f)
            {
                arr.velocity = newvector * -25.0f;
            }
            else if (distance1 > 0.25f)
            {
                arr.velocity = newvector * -28.0f;
            }


                ; //bow.transform.TransformDirection(Vector3.Slerp(bow.transform.position, arr.velocity.normalized, Time.deltaTime * 2)) * 18.0f;
                //arr.transform.position = Vector3.Slerp(arr.transform.position, arr.velocity.normalized, Time.deltaTime);



                //arr.AddForce(-transform.position * 15.0f);


                flag = false;



            transform.localPosition = new Vector3(0, 0, -0.162f);
            var rotationVector = transform.localRotation.eulerAngles;
            rotationVector = new Vector3(0, 0, 0);
                    transform.localRotation = Quaternion.Euler(rotationVector);










            }
        timer -= Time.deltaTime;
        //print(timer);
        if (timer < 0)
        {
            arr.GetComponent<respawnscript>().RespawnPoint();

            timer = 2.0f;
        }


    }
    

    public static bool IsPinching(Handedness trackedHand)
    {
        
        return HandPoseUtils.CalculateIndexPinch(trackedHand) > PinchThreshold;

    }
    void FixedUpdate()
    {
        if (arr.velocity != Vector3.zero)
            arr.rotation = Quaternion.LookRotation(arr.velocity);
    }

}



