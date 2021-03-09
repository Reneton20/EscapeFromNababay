using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health = 3;
    public Slider healthbar;

   void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        health -= 1;
    }

     void Update()
    {
      //  Debug.Log(health);
        healthbar.value = health;
    }




}
