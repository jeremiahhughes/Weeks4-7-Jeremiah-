using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressE : MonoBehaviour
{
    public float movespeed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        pos.y += Input.GetAxis("Vertical") * movespeed * Time.deltaTime;

        transform.position = pos;
    }
}
