using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float duration = 10f;
    public float timer = 0f;
    public float newSpeed = 5f;
    public float moveSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
        timer += Time.deltaTime;

        if(timer >= duration)
        {
            Destroy(gameObject);
        }
    }
    public void UpdateMoveSpeed(float newSpeed)
    {
        moveSpeed = newSpeed;
    }
}
