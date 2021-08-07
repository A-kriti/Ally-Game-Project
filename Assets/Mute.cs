using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Mute : MonoBehaviour
{


    public void mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}