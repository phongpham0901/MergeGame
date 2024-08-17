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
        audioManager = FindObjectOfType<AudioManager>();
        sliderSFX.GetComponent<Slider>().value = PlayerPrefs.GetFloat("sfx", 0.5f);
        sliderMusic.GetComponent<Slider>().value = PlayerPrefs.GetFloat("music", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hiiii");
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
