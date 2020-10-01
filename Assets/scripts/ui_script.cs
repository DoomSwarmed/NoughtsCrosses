using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// this script is applied to all of the button gameobjects

public class ui_script : MonoBehaviour
{
    public static float musicVol = 1.0f;
    public static float sfxVol = 1.0f;
    public bool toggle;

    public void MusicSoundOff()
    {
        toggle = !toggle;

        if (toggle)
            musicVol = 0f;
    }

    public void MusicSoundOn()
    {
        toggle = !toggle;

        if (!toggle)
            musicVol = 1f;
    }
    public void SFXSoundOff()
    {
        toggle = !toggle;

        if (toggle)
            sfxVol = 0f;
    }

    public void SFXSoundOn()
    {
        toggle = !toggle;

        if (!toggle)
        sfxVol = 1f;
    }


    // method to set the background volume global variable
    public void music_OnValueChanged( float value )
    {
        musicVol = value;
    }

    // method to set the sound effect volume global variable
    public void sfx_OnValueChanged(float value)
    {
        sfxVol = value;
    }

    // this method is called when a button is pressed
    // this method is also called when a slider is dragged using the 'begin drag' and 'end drag' event triggers that are applied to the slider gameobjects
    public void ChangeScene_controls()
    {
        init_ui.menu = "controls";
        init_ui.playSfx = true;
    }

    // this method is called when the UI options button is clicked
    public void ChangeScene_options()
    {
        init_ui.menu = "options";
        init_ui.playSfx = true;
    }

    public void ChangeScene_play()
    {
        SceneManager.LoadScene(1);
    }

    // this method is called when the UI back button is clicked
    public void ChangeScene_start()
    {
        init_ui.menu = "start";
        init_ui.playSfx = true;
    }
    public void ChangeScene_audio()
    {
        init_ui.menu = "audio";
        init_ui.playSfx = true;
    }
    public void ChangeScene_difficulty()
    {
        init_ui.menu = "difficulty";
        init_ui.playSfx = true;
    }


    public void button_click()
    {
        init_ui.playSfx = true;

    }

    public void tick()
    {
        init_ui.playSfx1 = true;
    }
    public void QuitGame()
    {

        Application.Quit();
        Debug.Log("Quitted The game");
    }

}
