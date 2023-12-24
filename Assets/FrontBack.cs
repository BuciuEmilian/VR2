using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontBack : MonoBehaviour
{
    public float startAngle;
    public float endAngle;
    public float speed;
    private float sign;
    void Start()
    {
        if (endAngle < startAngle)
        {
            sign = -1.0f;
        }
        else
        {
            sign = 1.0f;
        }
    }
    
    // Update is called once per frame
    void Update()
    {   
        float angle = sign * Mathf.PingPong(Time.time * speed, sign * (endAngle - startAngle)) + startAngle;
        transform.localRotation = Quaternion.Euler(0, 0, angle);
    }
}
