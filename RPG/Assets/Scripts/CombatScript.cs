using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CombatScript : MonoBehaviour
{
    // Start is called before the first frame update

    public bool standard, darkness, divinity;
    public float maxPlayerHP;
    public float playerHP;
    public float maxEnemyHP;
    public float enemyHP;
    public float maxPlayerAP;
    public float playerAP;
    public bool outOfAP = false;
    public string winScreen;
    public string loseScreen;


    //public bool initCombat = false;

    public GameObject PlayerUnit;
    public GameObject EnemyUnit;
    public Transform emptyLocation;
    public float damage;
    public float attackDamage;

    PlayerUnit playerUnit;
    Unit enemyUnit;

    public Image EnemyHPBar;
    public Image PlayerHPBar;
    public Image PlayerAPBar;

    public bool initOnce = true;

    public Button standardAttack;
    public Button darkButton;
    public Button divineButton;

    public bool turnSwitch = false;
    public bool inCombat = false;

    private void Awake()
    {
        inCombat = true;
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        if(initOnce == true)
        {
            GameObject empty = GameObject.Instantiate(EnemyUnit, emptyLocation);
            GameObject playerEmpty = GameObject.Instantiate(PlayerUnit, emptyLocation);
            playerUnit = playerEmpty.GetComponent<PlayerUnit>();
            enemyUnit = empty.GetComponent<Unit>();
            damage = enemyUnit.damage;
            attackDamage = playerUnit.attackDamage;
            maxPlayerHP = playerUnit.maxHealth;
            playerHP = maxPlayerHP;
            maxPlayerAP = playerUnit.maxAbilityPoints;
            playerAP = maxPlayerAP;
            maxEnemyHP = enemyUnit.maxHealth;
            enemyHP = maxEnemyHP;
            initOnce = false;
        }
    }

    public void Attack()
    {
        enemyHP -= attackDamage;
        EnemyHPUpdate();
        if (enemyHP <= 0)
        {
            WinGame();
        }
        turnSwitch = true;
    }

    public void DarkAttack()
    {
        enemyHP -= attackDamage * 5;
        EnemyHPUpdate();
        playerAP -= 2;
        playerHP -= 2;
        PlayerHPUpdate();
        PlayerAPUpdate();
        if (enemyHP <= 0)
        {
            WinGame();
        }

        if (playerAP <= 0)
        {
            darkButton.GetComponent<Button>().interactable = false;
        }
        turnSwitch = true;

    }

    public void DivineAttack()
    {
        playerAP -= 3;
        playerHP += 10;
        PlayerHPUpdate();
        PlayerAPUpdate();
        if (enemyHP <= 0)
        {
            WinGame();
        }

        if (playerAP <= 0)
        {
            outOfAP = true;
        }
        turnSwitch = true;
    }


    void EnemyCombat()
    {
        playerHP -= damage;
        playerUnit.currentHealth -= damage;
        Debug.Log("Subtracted Damage");
        PlayerHPUpdate();
        if (playerHP <= 0)
        {
            LoseGame();
        }
        standardAttack.interactable = true;
        darkButton.interactable = true;
        divineButton.interactable = true;
    }

    public void EnemyHPUpdate()
    {
        EnemyHPBar.fillAmount = Mathf.Clamp(enemyHP / maxEnemyHP, 0, maxEnemyHP);
    }

    public void PlayerHPUpdate()
    {
        PlayerHPBar.fillAmount = Mathf.Clamp(playerHP / maxPlayerHP, 0, maxPlayerHP);
    }

    public void PlayerAPUpdate()
    {
        PlayerAPBar.fillAmount = Mathf.Clamp(playerAP / maxPlayerAP, 0, maxPlayerAP);
    }

    public void LevelUp()
    {
        playerUnit.entityLevel += 1;

        maxPlayerHP += 10;

        playerHP = maxPlayerHP;
    }

void WinGame()
    {
        SceneManager.LoadScene(winScreen);
        inCombat = false;
    }

    void LoseGame()
    {
        SceneManager.LoadScene(loseScreen);
        inCombat = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(inCombat == true)
        {
            if (turnSwitch == true)
            {
                standardAttack.interactable = false;
                darkButton.interactable = false;
                divineButton.interactable = false;
                Invoke("EnemyCombat", 2);
                turnSwitch = false;
            }
            if (outOfAP == true)
            {
                darkButton.interactable = false;
                divineButton.interactable = false;
            }
            if (playerHP <= 2)
            {
                darkButton.interactable = false;
            }
        }
    }
}