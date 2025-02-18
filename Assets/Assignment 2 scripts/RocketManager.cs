using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketManager : MonoBehaviour
{
    public GameObject Rocket;
    public Transform spawnPoint;
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
        Instantiate(Rocket, spawnPoint);
        Debug.Log("rocket spawned");
    }
}
