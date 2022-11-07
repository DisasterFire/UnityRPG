using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EnemyInteraction : MonoBehaviour
{
    public Collider2D player;
    public Transform playerPos;
    public Collider2D assailant;

    public string combatScreen;

    // Update is called once per frame
    void Update()
    {
        EnterCombat();
    }

    void EnterCombat()
    { 
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("Engaging Combat Systems");
            SceneManager.LoadScene(combatScreen);
        }
    }

}
