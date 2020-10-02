using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour {
    public float seconds;
    public float minutes;
    public Text textBox;

    bool timerActive = true;

	// Use this for initialization
	void Start () {
        textBox.text = seconds.ToString("");
	}
	
	// Update is called once per frame
	void Update () {
        if(timerActive){
            seconds += (Time.deltaTime % 60);
            minutes += (Time.deltaTime / 60);
            if (seconds > 60)
            {
                seconds = 0;
            }
            int secc = (int)seconds;
            int mins = (int)minutes;
            textBox.text = "TIMER: " + mins.ToString("00") + ":" + secc.ToString("00");

        }
	}
}