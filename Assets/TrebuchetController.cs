using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrebuchetController : MonoBehaviour
{
    public Rigidbody weight;

    public GameObject ammo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            weight.isKinematic = false;
        }
        if  (Input.GetKeyUp(KeyCode.Space))
        {
            HingeJoint joint = ammo.GetComponent<HingeJoint>();
            Destroy(joint);
        }
    }
}
