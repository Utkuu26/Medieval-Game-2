using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemainingEnemyCounter : MonoBehaviour
{
    public TextMeshProUGUI remainingEnemy;
    public TextMeshProUGUI missionText;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingEnemy.text== "Remaining Enemy: 0")
        {
            missionText.text = "Village saved successfully thanks to you";
        }
    }
}
