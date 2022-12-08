using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCBehavior : MonoBehaviour
{

    public Button STR, Dark, Divine;

    public bool talkFive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress()
    {
        Time.timeScale = 0;
        STR.interactable = true;
        Dark.interactable = true;
        Divine.interactable = true;
    }

    public void CasualConversation()
    {
        GameManager.instance.str += 2;
        Time.timeScale = 1;
        STR.interactable = false;
        Dark.interactable = false;
        Divine.interactable = false;
    }

    public void Kindness()
    {
        GameManager.instance.divine += 5;
        GameManager.instance.dark -= 5;
        GameManager.instance.maxPlayerHP += 5;
        Time.timeScale = 1;
        STR.interactable = false;
        Dark.interactable = false;
        Divine.interactable = false;
    }

    public void Threat()
    {
        GameManager.instance.dark += 5;
        GameManager.instance.divine -= 5;
        GameManager.instance.maxPlayerHP += 5;
        GameManager.instance.attackDamage += 5;
        Time.timeScale = 1;
        STR.interactable = false;
        Dark.interactable = false;
        Divine.interactable = false;
    }
}
