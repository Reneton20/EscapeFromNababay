using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textdamage : MonoBehaviour
{
    [SerializeField] private float sui;
    [SerializeField] private Texthealth Health;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Damage();
        }
    }

    void Damage()
    {
        Health.playerhealth = Health.playerhealth - sui;
        Health.UpdateHealth();
        this.gameObject.SetActive(false);
    }
}
