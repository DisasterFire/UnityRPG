using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour
{
    public string mainMenu;

    public void OnButtonPress()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
