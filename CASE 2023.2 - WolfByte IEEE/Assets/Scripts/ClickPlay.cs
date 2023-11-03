using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickPlay : MonoBehaviour
{
    public Text text;
    void Start()
    { 
        text.enabled = false;
    }

    public void Play()
    {   
        SceneManager.LoadScene("CenaPrincipal");
    }

    public void Credits()
    {
        if(text.enabled == false)
        {
            text.enabled = true;
        }
        else
        {
            text.enabled = false;
        }
        
    }

    public void Exit() 
    {
        UnityEditor.EditorApplication.ExitPlaymode(); // mantemos esse enquanto não pretendemos buildar o jogo final :)
        //Application.Quit();
    }
}
