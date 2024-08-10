using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleCollection : MonoBehaviour
{
    [SerializeField] private GameController gameController;
    
    [Header("Score Value for This Location")]
    public int scoreValue = 1;
    
    private void Awake()
    {
        if (gameController == null)  // Ensure gameController is found
        {
            gameController = FindObjectOfType<GameController>();
        }
    }
    
    public void AsteroidSampleCollection()
    {
        if(gameController != null){
            gameController.UpdatePlayerScore(scoreValue);
            Debug.Log("Asteroid collected! Score awarded: " + scoreValue);
        }
        else{
            Debug.LogError("GameController is not found.");
        }
    }
}
