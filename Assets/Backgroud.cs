using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Backgroud : MonoBehaviour
{
    public float Rot = 2f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,Rot * Time.deltaTime); 
    }
}
