using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // (Input.GetButtonDown("Cancel"))
        {
            print("We pushed Escape button");
            Application.Quit();
        }
    }
}
