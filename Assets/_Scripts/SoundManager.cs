using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour{

    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }

        else
        {
            Load();
        }
    }

 public void OnButtonPRess()
    {
        if(muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else { muted = false; AudioListener.pause = false; }
        Save();
    }

    private void Load() { muted = PlayerPrefs.GetInt("muted") == 1; }
    private void Save() { PlayerPrefs.SetInt("muted", muted ? 1 : 0); }
}
