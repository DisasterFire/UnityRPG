using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public int entityLevel;

    public float attackDamage;

    public float str = GameManager.instance.str;
    public float dark = GameManager.instance.dark;
    public float divine = GameManager.instance.divine;

    public float maxHealth = GameManager.instance.maxPlayerHP;
    public float currentHealth = GameManager.instance.playerHP;

    public float maxAbilityPoints = GameManager.instance.maxPlayerAP;
    public float abilityPoints = GameManager.instance.playerAP;

    public void LevelUp()
    {
        entityLevel += 1;

        maxHealth += 10;

        currentHealth = maxHealth;
    }
}
