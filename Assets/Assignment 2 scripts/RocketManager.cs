using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketManager : MonoBehaviour
{
    public GameObject Rocket; // referencing Rocket Prefab 
    public Transform spawnPoint; // referencing the Spawnpoint for my rocket
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RocketSpawner()
    {
        Instantiate(Rocket, spawnPoint); // instantiates the rocket at the position of the spawn point
        Debug.Log("rocket spawned!"); // this debug log was to check whether the rocket was spawned 
       
    }
}
