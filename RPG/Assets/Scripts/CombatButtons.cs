using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CombatButtons : MonoBehaviour
{
    public bool standard, darkness, divinity;
    public int maxEnemyHP;
    public int enemyHP;
    public int maxPlayerAP;
    public int playerAP;
    public bool outOfAP = false;
    public string winScreen;
    bool sInitialized = false;
    bool dInitialized = false;

    public Button darkButton;
    public Button divineButton;

    public void ViewEnemyStats()
    {

    }

    public void StandardAbilities()
    {
        standard = true;
        darkness = false;
        divinity = false;
        if(!sInitialized)
        {
            enemyHP = maxEnemyHP;
            sInitialized = true;
        }
    }

    public void DarknessAbilities()
    {
        standard = false;
        darkness = true;
        divinity = false;

        if (!sInitialized)
        {
            enemyHP = maxEnemyHP;
            sInitialized = true;
        }

        if (!dInitialized)
        {
            playerAP = maxPlayerAP;
            dInitialized = true;
        }

    }

    public void DivinityAbilities()
    {
        standard = false;
        darkness = false;
        divinity = true;

        if (!sInitialized)
        {
            enemyHP = maxEnemyHP;
            sInitialized = true;
        }

        if (!dInitialized)
        {
            playerAP = maxPlayerAP;
            dInitialized = true;
        }
    }

    public void Attack()
    {   
        enemyHP -= 2;
        if(enemyHP <= 0)
        {
            WinGame();
        }
    }

    public void DarkAttack()
    {
        enemyHP -= 5;
        playerAP -= 2;
        if (enemyHP <= 0)
        {
            WinGame();
        }

        if(playerAP <= 0)
        {
           darkButton.GetComponent<Button>().interactable = false;
        }

    }

    public void DivineAttack()
    {
        enemyHP -= 10;
        playerAP -= 3;
        if (enemyHP <= 0)
        {
            WinGame();
        }

        if (playerAP <= 0)
        {
            outOfAP = true;
        }
    }

    void WinGame()
    {
        SceneManager.LoadScene(winScreen);
    }
}
