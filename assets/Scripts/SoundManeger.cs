 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManeger : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] float startVolume;
    const string key = "musicVolume";
    const float startVol = 1.0f; 
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey(key))
        {
            startVolume = PlayerPrefs.GetFloat(key);
            AudioListener.volume = startVolume;
            volumeSlider.value = startVolume;
            PersistentData.Instance.SetVolume(volumeSlider.value);
        }

        else
        {
            PlayerPrefs.SetFloat(key, startVol);
        }
    }
    void update()
    {
        ChangeVolume();
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    } 

    public void Save()
    {
        PlayerPrefs.SetFloat(key, volumeSlider.value);
    }
          
}
