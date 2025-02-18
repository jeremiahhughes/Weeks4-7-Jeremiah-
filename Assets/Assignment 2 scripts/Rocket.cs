using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float duration = 10f; // duration of how long the rocket stays on screen in seconds
    public float timer = 0f; // timer for when to destroy the GameObject
    public float newSpeed = 5f; // this is for the speed that the rocket can go using the slider (it can be adjusted in the inspector)
    public float moveSpeed = 2f; // default movespeed for the rocket
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0); // Object moves on the Y axis based on the movespeed value, also using Time.deltaTime for a smooth motion
        timer += Time.deltaTime;

        if(timer >= duration) // if the timer is more or equal to the set duration the game object gets destroyed
        {
            Destroy(gameObject);
            Debug.Log("rocket destroyed!"); // this debug log was to tell me when the rocket gets destroyed
        }
    }
    public void UpdateMoveSpeed(float newSpeed) // this updated the move speed using a slider
    {
        moveSpeed = newSpeed;
    }
}
