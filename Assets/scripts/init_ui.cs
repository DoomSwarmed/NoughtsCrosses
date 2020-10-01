﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init_ui : MonoBehaviour
{
    

    // add your other menu variables here and link to them in the Unity inspector
    public GameObject menu_1;
    public GameObject menu_2;

    public AudioSource audioSource1;    // this is the background music source
    public AudioSource audioSource2;    // sound effects audio source
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    public AudioClip bgMusic;
    public AudioClip sfx1;
    public AudioClip sfx2;
    public AudioClip sfx3;
    public static string menu = "start";
    public static bool playSfx = false;
    public static bool playSfx1 = false;
    public static bool playSfx2 = false;



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("up"))
        {
            audioSource4.PlayOneShot(sfx3, ui_script.sfxVol);
        }

        if (Input.GetKeyDown("right"))
        {
            audioSource4.PlayOneShot(sfx3, ui_script.sfxVol);
        }

        if (Input.GetKeyDown("left"))
        {
            audioSource4.PlayOneShot(sfx3, ui_script.sfxVol);
        }
        if (Input.GetKeyDown("down"))
        {
            audioSource4.PlayOneShot(sfx3, ui_script.sfxVol);
        }
        // this method is called from the camera gameObject and checks to see which menu should be displayed

        Vector3 enable = new Vector3(0, 0, 0);  // position of the menu to make it visible
        Vector3 disable = new Vector3(100000.0f, 0, 0);   // position of the menu to move it off screen

        // move the chosen menu into view and move the others off screen
        if (menu == "start")
        {
            menu_1.transform.position = enable;     // if we have chosen to view the "start" menu, move the other menus offscreen
            menu_2.transform.position = disable;
        }

        if (menu == "options")
        {
            menu_1.transform.position = disable;    // if we have chosen to view the "options" menu, move the other menus offscreen
            menu_2.transform.position = enable;

        }

        if (menu == "quit")
        {
            Quit();
        }

        // set the volume level from the slider variable
        audioSource1.volume = ui_script.musicVol;

        // check if the global variable playSfx is set to true. If it is, play the sound effect
        if ( playSfx == true )
        {
            audioSource2.PlayOneShot(sfx1, ui_script.sfxVol);       // play the sound effect at the volume set it the slider variable
            playSfx = false;
        }

        if ( playSfx1 == true)
        {
            audioSource3.PlayOneShot(sfx2, ui_script.sfxVol);
            playSfx1 = false;
        }
        if (playSfx2 == true)
        {
            audioSource4.PlayOneShot(sfx3, ui_script.sfxVol);
            playSfx2 = false;
        }


        void Quit()
        {
            Application.Quit();
        }

}
}



