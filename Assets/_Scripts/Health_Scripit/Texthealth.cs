using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Texthealth : MonoBehaviour
{
    public float playerhealth;
    [SerializeField] private Text healthtext;

    public void UpdateHealth()
    {
        healthtext.text = playerhealth.ToString("0");  

        if(playerhealth == 0)
        {
            SceneManager.LoadScene(4);
        }
    }
}
