using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float v;

    // Update is called once per frame
    void Update()
    {
        float da = Time.deltaTime * v;
        transform.Rotate(Vector3.up, da);
    }
}
