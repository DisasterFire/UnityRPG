using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public int entityLevel;

    public float attackDamage;

    public float str;
    public float dark;
    public float divine;

    public float maxHealth;
    public float currentHealth;

    public float maxAbilityPoints;
    public float abilityPoints;

    public bool initOnce = true;
    public bool secondInit = false;

    public void LevelUp()
    {
        entityLevel += 1;

        maxHealth += 10;

        currentHealth = maxHealth;
    }

    public void initCombat()
    {
        initOnce = false;
    }
    
    public void init2nd()
    {
        secondInit = true;
    }
}
