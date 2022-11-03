using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EnemyInteraction : MonoBehaviour
{
    public GameObject player;
    public Transform playerPos;
    public GameObject assailant;

    public string combatScreen;

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Entered");
        EnterCombat();
    }

    void EnterCombat()
    {
        if(Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene(combatScreen);
        }
    }

}
