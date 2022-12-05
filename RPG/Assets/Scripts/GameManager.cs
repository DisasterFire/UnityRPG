using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float maxPlayerHP;
    public float playerHP;
    public float maxEnemyHP;
    public float enemyHP;
    public float maxPlayerAP;
    public float playerAP;
    public bool outOfAP = false;

    public static GameManager instance;

    public float attackDamage;

    public int entityLevel;

    public float str;
    public float dark;
    public float divine;

    public bool initOnce = true;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        maxPlayerHP = 20;
        maxEnemyHP = 50;
        maxPlayerAP = 35;

        playerHP = maxPlayerHP;
        enemyHP = maxEnemyHP;
        playerAP = maxPlayerAP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealth(float currentHP)
    {
        playerHP = currentHP;
    }

    public void UpdateAbility(float currentAP)
    {
        playerAP = currentAP;
    }
}
