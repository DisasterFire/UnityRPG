using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatButtons : MonoBehaviour
{
    public bool standard, darkness, divinity;
    public int maxEnemyHP = 20;
    public int enemyHP;

    public void ViewEnemyStats()
    {

    }

    public void StandardAbilities()
    {
        standard = true;
        darkness = false;
        divinity = false;
        enemyHP = maxEnemyHP;
    }

    public void DarknessAbilities()
    {
        standard = false;
        darkness = true;
        divinity = false;
    }

    public void DivinityAbilities()
    {
        standard = false;
        darkness = false;
        divinity = true;
    }

    public void Attack()
    {
        enemyHP -= 1;
    }
}
