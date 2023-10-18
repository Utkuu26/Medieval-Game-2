using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
           StartCoroutine(Congrats(3f)); 
        }
    }

    private IEnumerator Congrats(float waitTime)
    {
        missionText.text = "Village saved successfully thanks to you";
       yield return new WaitForSeconds(waitTime);
       SceneManager.LoadScene(3);
    }
}
