using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Backgroud : MonoBehaviour
{
    public float Rot = 2f;  // speed of the rotation
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,Rot * Time.deltaTime); // This Rotates the Z axis so that my backgroud feels more spacelike
    }
}
