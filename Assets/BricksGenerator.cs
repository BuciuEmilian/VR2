using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BricksGenerator : MonoBehaviour
{
    public float wallWidth;

    public float wallHeight;
    // Start is called before the first frame update
    void Start()
    {
        GameObject prefab = Resources.Load("brick") as GameObject;
        for (int row = 0; row < wallHeight; row++)
        {
            float offset = row % 2;
            for (int brick_idx = 0; brick_idx < wallWidth - offset; brick_idx++) 
            {
                GameObject brick = Instantiate(prefab) as GameObject;
                float scaleX = brick.transform.localScale.x;
                float scaleY = brick.transform.localScale.y;
                brick.transform.position = new Vector3(
                    transform.position.x + scaleX * (brick_idx + 0.5f * offset),
                    transform.position.y + scaleY * (row + 0.5f),
                    transform.position.z
                );
            }
        }
    }
}
