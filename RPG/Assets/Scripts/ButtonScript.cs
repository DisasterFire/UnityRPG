using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public string previousScreen;
    public string nextScreen;

    public void ReturnToPreviousScreen()
    {
        SceneManager.LoadScene(previousScreen);
    }

    public void NextScreen()
    {
        SceneManager.LoadScene(nextScreen);
    }
}
