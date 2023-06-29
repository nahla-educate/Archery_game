using UnityEngine.XR.Interaction.Toolkit;

public class Bow : XRGrabInteractable
{
   // public GameObject PointPrefab;
   // public GameObject[] Points;
    //public int numberofpoint ;
    private Notch notch = null;

    protected override void Awake()
    {
        base.Awake();
        notch = GetComponentInChildren<Notch>();
       /* Points = new GameObject[numberofpoint];
        for(int i = 0; i<numberofpoint ; i++){
            Points[i]= Instantiate(PointPrefab, transform.position,Quaternion.identity);
        }*/

    }
    /*Vector3 PointPosition(float t){
        Vector3 currentPointPos = (Vector3)transform.position +
    }*/

    protected override void OnEnable()
    {
        base.OnEnable();

        // Only notch an arrow if the bow is held
        selectEntered.AddListener(notch.SetReady);
        selectExited.AddListener(notch.SetReady);
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        selectEntered.RemoveListener(notch.SetReady);
        selectExited.RemoveListener(notch.SetReady);
    }
}
