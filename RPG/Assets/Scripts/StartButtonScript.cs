using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public string gameLevel;
    public string instructions;
    public string credits;
    
    public void OnButtonPress()
    {
        Debug.Log("Button Pressed");
        SceneManager.LoadScene(gameLevel);
    }

    public void OnTutoButtonPress()
    {
        Debug.Log("Button Pressed");
        SceneManager.LoadScene(instructions);
    }

    public void OnCreditsButtonPress()
    {
        Debug.Log("Button Pressed");
        SceneManager.LoadScene(credits);
    }

}
