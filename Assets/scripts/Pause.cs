﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool paused = false;

    void Update()
    {
       if(Input.GetKeyDown("escape"))
        {
            paused = togglePause();
        }  
    }

    void OnGUI()
    {
       if(paused)
        {
            GUILayout.Space(10);
            GUILayout.Label("Game is paused");
            if(GUILayout.Button("Resume"))
            {
                paused = togglePause();
            }
        } 
    }

    bool togglePause()
    {
        if(Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return (false);
        }
        else
        {
            Time.timeScale = 0f;
            return (true);
        }
    }
}
