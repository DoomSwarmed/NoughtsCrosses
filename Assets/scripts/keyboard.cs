using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard : MonoBehaviour
{
    public AudioSource crack;
    public AudioClip pop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            crack.PlayOneShot(pop, ui_script.sfxVol);
        }

        if (Input.GetKeyDown("right"))
        {
            crack.Play();
        }

        if (Input.GetKeyDown("left"))
        {
            crack.Play();
        }
        if (Input.GetKeyDown("down"))
        {
            crack.Play();
        }
    }
}
