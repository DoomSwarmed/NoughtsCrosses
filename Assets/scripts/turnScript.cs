using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turnScript : MonoBehaviour
{
    public bool oturn;
    public bool xturn;
    public Text otext;
    public Text xtext;
    
    // Start is called before the first frame update
    void Start()
    {
        oturn = true;
      otext.text = "O's\nturn";
        xturn = false;
        xtext.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (oturn == true) {
            otext.text = "O's\nturn";
        }
        else {
            xtext.text = "X's\nturn";
        }
        
    }

    public void ChangeTurns()
    {
        if (oturn == true) {
            oturn = false;
            otext.text = "";
            Debug.Log("djsd");
        }
        else {
            oturn = true;
            otext.text = "O's\nturn";
            xtext.text = "";


        }
    }
}
