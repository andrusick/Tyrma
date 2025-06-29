using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vector : MonoBehaviour
{
    protected Patrolling patrolling;
    // Start is called before the first frame update
    void Start()
    {
        patrolling = GetComponent<Patrolling>();
    }

    // Update is called once per frame
    void Update()
    {
         void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "zone")
            {
                Debug.Log("erdred");
                patrolling.vector = !patrolling.vector;   
            }
        }
    }
}
