using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    
    [SerializeField] private Image timerImage;
    [SerializeField] private float gameTime;
    private float sliderCurrentFillAmount = 2f;

    [Header("Score Components")]
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] public GameObject robot;
    private bool isGameOver = false;

    private int playerScore;

    [SerializeField] private RobotRemoteControl RobotRemoteControl;

    private bool hasStoppedRobot =false;

    private void Update()
    {
        AdjustTimer();
        if (isGameOver && !hasStoppedRobot){
            StopRover();
        }
    }

    private void AdjustTimer()
    {
        timerImage.fillAmount = sliderCurrentFillAmount - (Time.deltaTime/ gameTime);
        sliderCurrentFillAmount = timerImage.fillAmount;
        if(timerImage.fillAmount <=0 ){
            isGameOver = true;
        }
    }
    
    public void UpdatePlayerScore(int scoreValue){
        playerScore += scoreValue;
        /*Debug.LogError("Checking scoreText assignment: " + scoreText);*/
        if (scoreText != null) {
            scoreText.text = playerScore.ToString();
        }else{
            Debug.LogError("scoreText is not set on GameController");
        }
    }

    
    private void StopRover(){
        RobotRemoteControl robotController = robot.GetComponent<RobotRemoteControl>();
        if (robotController != null){
            robotController.StopMoving();
            hasStoppedRobot = true;
        }
        else{
        Debug.LogError("RobotRemoteControl instance not found.");
        }
    }
}