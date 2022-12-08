using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Interactable : MonoBehaviour
{
    public Button Talk;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Talk.interactable = false;
        }
        else
        {
            Talk.interactable = true;
        }
        
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Talk.interactable = false;
    }

}
