using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EnemyInteraction : MonoBehaviour
{
    public string combatScreen;

    // Update is called once per frame

    public void EnterCombat()
    { 

         Debug.Log("Engaging Combat Systems");
         SceneManager.LoadScene(combatScreen);

    }

}
