﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addscore : MonoBehaviour
{
    
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score.Score++;
    }
}
