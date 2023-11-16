using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseControl : MonoBehaviour
{
    public GameObject pauseMenu;

    void Start() 
    {
        pauseMenu.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && Time.timeScale == 0f)
        {
            Time.timeScale = 1.0f;
            pauseMenu.SetActive(false);
        }
        else if(Input.GetKeyDown("space"))
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }
    }
}
