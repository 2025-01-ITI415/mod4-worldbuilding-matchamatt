using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 10f;
    public Text timerText;
    private bool countingDown = true;
    public MonoBehaviour FirstPersonController;
  


    void Start(){
        timerText.text = "";
    }

    void Update()
    {
        if (countingDown)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                countingDown=false;
                if(FirstPersonController != null){
                    FirstPersonController.enabled = false;
                }
                 
                
            }
            UpdateTimer();
        }
    }

    void UpdateTimer()
    {
        int min = Mathf.FloorToInt(timeRemaining / 60);
        int sec = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", min, sec);
    }
}
