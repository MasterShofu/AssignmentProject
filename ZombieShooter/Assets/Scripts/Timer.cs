using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{  
    public Text timerText;
    private float _startTime;
    private bool finished = false;

    public Health endhealth;

    void Start()
    {
        _startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(finished)
        return;

        float t = Time.time - _startTime;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    
        if(endhealth.isDead){
            finished = true;
            timerText.color = Color.yellow;
        }

    }
}