using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCanvas : MonoBehaviour
{
    public GameObject canvas;
    public Transform player;
    public float activationDistance = 11f;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        if ( canvas != null)
        {
            canvas.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
         distance = Vector3.Distance(player.position, Camera.main.ScreenToWorldPoint(transform.position));
        

        if (distance >= activationDistance)
        {
            Appear();
        }
        else
        {
            Disappear();
        }
    }
    void Appear()
    {
        if (canvas != null)
        {
            canvas.SetActive(true);
        }
    }

    void Disappear()
    {
        if (canvas != null)
        {
            canvas.SetActive(false);
        }
    }
}
