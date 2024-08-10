using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set;}

    public int TotalScore{get; private set;}

    private void Awake(){
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    public void AddScore(int scoreToAdd){
        TotalScore += scoreToAdd;
        Debug.Log("Total Score:" + TotalScore);
    }
}
