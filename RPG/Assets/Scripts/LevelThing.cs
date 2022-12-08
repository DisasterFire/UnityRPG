using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelThing : MonoBehaviour
{
    public Button Battle;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "NPC")
        {
            Battle.interactable = false;
        }
        else
        {
            Battle.interactable = true;
        }
        
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Battle.interactable = false;
    }

}
