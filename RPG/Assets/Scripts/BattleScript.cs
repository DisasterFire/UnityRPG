using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum CombatState { START, PLAYER_TURN, ASSAILANT_TURN, VICTORY, DEFEAT}

public class BattleScript : MonoBehaviour
{
    public GameObject player;
    public GameObject assailant;

    public TMP_Text assailantDialogue;

    public Transform playerStation;
    public Transform assailantStation;

    Unit playerUnit;
    Unit assailantUnit;

    public CombatState state;
    
    // Start is called before the first frame update
    void Start()
    {
        state = CombatState.START;
        CreateCombat();
    }

    void CreateCombat()
    {
        GameObject playerObject = Instantiate(player, playerStation);
        playerUnit = playerObject.GetComponent<Unit>();


        GameObject assailantObject = Instantiate(assailant, assailantStation);
        assailantUnit = assailantObject.GetComponent<Unit>();

        assailantDialogue.text = assailantUnit.entityName + ", " + assailantUnit.entityProfession;

    }

}
