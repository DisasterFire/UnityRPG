using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatButtons : MonoBehaviour
{
    public bool standard, darkness, divinity;
    public string userInput;

    public void ViewEnemyStats()
    {

    }

    public void StandardAbilities()
    {
        standard = true;
        darkness = false;
        divinity = false;
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
}
