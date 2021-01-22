using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySetting : MonoBehaviour
{
    bool paused;
    // Start is called before the first frame update
    void Start()
    {
        paused = true;
        Time.timeScale = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        print(Time.time);
        if (Input.GetKeyDown(KeyCode.Space) && paused)
        {
            paused = false;
            Time.timeScale = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && !paused)
        {
            paused = true;
            Time.timeScale = 0;
        }
    }
}
