using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingbackground : MonoBehaviour
{
    public Renderer bgo;
    public float bgospeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgo.material.mainTextureOffset += new Vector2(bgospeed * Time.deltaTime, 0f);
    }
}
