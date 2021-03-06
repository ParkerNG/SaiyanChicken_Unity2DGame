﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeCounter : MonoBehaviour {
    private Text counterText;
    private float seconds, minutes;
    private float time;
	// Use this for initialization
	void Start () {
        counterText = GetComponent<Text>() as Text;
        time = TimerSingleton._instance.timeValue;
    }
	
	// Update is called once per frame
	void Update () {
        minutes = (int)(Time.timeSinceLevelLoad/60f) + (int)(time / 60f);
        seconds = (int)(Time.timeSinceLevelLoad % 60f ) + (int)(time % 60f);
        counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");        
    }
}
