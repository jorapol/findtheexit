using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer;
    public Text timerText;
    bool gameOver;

    void Update()
    {
        timer += Time.deltaTime;
        
        //as long as the player is still in the maze (not gameover), then update the timer on the screen
        if(!gameOver){
            timerText.text = timer.ToString("F2"); //display 2 decimal points
        }
    }

    void OnTriggerEnter(Collider other){
        //if hit the exit trigger, then gameover is true
        if(other.gameObject.CompareTag("exit")){
            gameOver = true; 
        }
    }
}
