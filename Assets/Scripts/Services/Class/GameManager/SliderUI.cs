using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SliderUI : MonoBehaviour
{
    private AudioManager audioManager;
    [SerializeField] private GameObject sliderSFX;
    [SerializeField] private GameObject sliderMusic;

    private void Awake()
    {
        sliderSFX.GetComponent<Slider>().value = PlayerPrefs.GetFloat("sfx");
        
        sliderMusic.GetComponent<Slider>().value = PlayerPrefs.GetFloat("music");

    }
    
    // Start is called before the first frame update
    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        audioManager.sfxVolume = sliderSFX.GetComponent<Slider>().value;
        audioManager.GetComponent<AudioSource>().volume = sliderMusic.GetComponent<Slider>().value;
        
        SaveValue();
    }

    void SaveValue()
    {
        PlayerPrefs.SetFloat("sfx", audioManager.sfxVolume);
        PlayerPrefs.SetFloat("music", audioManager.GetComponent<AudioSource>().volume);
    }
    
}
