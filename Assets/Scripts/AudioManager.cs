using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    private GameObject gm;
    // Start is called before the first frame update
    void Awake()
    {
        gm = GameObject.Find("GameManager");

        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            
            Load();
            //gm.GetComponent<GameManagerScript>().MM.enabled = true;
            gm.GetComponent<GameManagerScript>().MM.playOnAwake = false;
        }
        else
        {
            Load();
        }
        
    
        
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
