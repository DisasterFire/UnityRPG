using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatScript : MonoBehaviour
{
    public TextMeshProUGUI str;
    public TextMeshProUGUI darkness;
    public TextMeshProUGUI divinity;
    public TextMeshProUGUI maxHealth;

    public void AddStats()
    {
        str.text = GameManager.instance.str.ToString();
        darkness.text = GameManager.instance.dark.ToString();
        divinity.text = GameManager.instance.divine.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        maxHealth.text = GameManager.instance.maxPlayerHP.ToString();
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
