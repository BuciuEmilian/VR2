using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSatelite : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.eulerAngles = new Vector3(
            -transform.eulerAngles.x,
            transform.eulerAngles.y,
            -transform.eulerAngles.z
        );
    }
}
