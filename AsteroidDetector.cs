using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public SampleCollection sampleCollection;  // Reference to the SampleCollection component

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Asteroid")){
            Debug.Log("Robot has encountered an asteroid!");
            // When conditions are met to collect the asteroid
            sampleCollection.AsteroidSampleCollection();
        }
    }
}


