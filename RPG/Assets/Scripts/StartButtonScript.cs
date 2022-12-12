using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public string gameLevel;
    public string instructions;
    public string narrative;
    public string credits;

    public Animator sceneSwap;
    public float delayTime;
    
    public void OnButtonPress()
    {
        StartCoroutine(LevelTransition(gameLevel));
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

    public void OnNarrative()
    {
        SceneManager.LoadScene(narrative);
    }

    IEnumerator LevelTransition(string levelName)
    {
        sceneSwap.SetTrigger("Start");

        yield return new WaitForSeconds(delayTime);

        SceneManager.LoadScene(levelName);
    }

}
