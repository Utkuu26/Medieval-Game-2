using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy1Stats : MonoBehaviour
{
    public int hp = 100;
    public Animator animator;
    public Animator Enemy2Anim;
    private bool isDead = false; 
    public BloodManager bm;
    public AudioSource EnemySource;
    public AudioClip dieSfx;
    private static int remainingEnemy = 4;
    public TMP_Text remaingEnemyTxt; 
    public GameObject damageTxt;
    public TMP_Text trigger;
    public bool isLevel1;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void TakeDamage(int damageAmount)
    {
        if (isDead) return;
        hp -= damageAmount;
        DamagePopUp popUp = Instantiate(damageTxt, transform.position, Quaternion.identity).GetComponent<DamagePopUp>();
        popUp.SetDamageText(damageAmount);

        if(hp <= 0)
        {
            isDead = true;
            if (isLevel1)
            {
                trigger.text = "Get Onboard and Go To Next Village";
                //Rigidbody rb = GetComponent<Rigidbody>();
                //rb.useGravity = false;
                //rb.velocity = Vector3.zero;
                //rb.angularVelocity = Vector3.zero;
                rb.isKinematic = true;
                animator.SetTrigger("Dying");
            }                  
            Enemy2Anim.SetTrigger("Dying2");
            rb.isKinematic = true;
            remainingEnemy -= 1;
            Debug.Log(remainingEnemy);
            remaingEnemyTxt.text =  "Remaining Enemy: " + remainingEnemy.ToString();
            //GetComponent<Collider>().enabled = false;
            bm.DestroyBlood();
           
            

            AudioSource au = GetComponent<AudioSource>();
            au.PlayOneShot(dieSfx, 3.0f);
         
             
        }
    }
}
