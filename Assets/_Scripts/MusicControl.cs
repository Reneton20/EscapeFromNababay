using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MusicControl : MonoBehaviour
{
    private static MusicControl bgm;
   // Scene scene = SceneManager.GetActiveScene();

    public void Awake()
     {
         if (bgm == null) 
         { 
             bgm = this;
             //DontDestroyOnLoad(bgm);
        }
        else
        {
            Destroy(bgm);
        }
     }
}
