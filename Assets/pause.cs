﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class pause : MonoBehaviour
{
    bool isPaused = false;

    

    public void pauseGame()
    {
        if (isPaused)
        {

            Time.timeScale = 1;
            isPaused = false;
            
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            
        }
    }
}
