using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public GameObject gameovercanvas;

    public GameObject PauseUI;

    // Start is called before the first frame update
    public void Start()
    {
        Time.timeScale = 1; 
    }

    // Update is called once per frame
    public void Gameover()
    {
        gameovercanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseuI()
    {
        PauseUI.SetActive(true);


    }

    public void PlayButton()
    {
        PauseUI.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }



    public void Replay()
    {
        SceneManager.LoadScene(0);
    }


}
