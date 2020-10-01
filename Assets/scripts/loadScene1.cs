using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
