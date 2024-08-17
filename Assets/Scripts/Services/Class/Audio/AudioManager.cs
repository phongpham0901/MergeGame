using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    [Header("SFX1")] 
    [SerializeField] public AudioClip clipSFX1;
    [SerializeField] public AudioClip clipSFX2;
    [SerializeField] [Range(0f, 1f)] public float sfxVolume = 0.5f;
    
    private static AudioManager instance;
    
    void Awake()
    {
        ManageInstance();
        sfxVolume = 0.5f;
        GetComponent<AudioSource>().volume = 0.5f;
    }

    void ManageInstance()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
    }

    public void PlaySFX1()
    {
        PlayClip(clipSFX1, sfxVolume);
    }
    
    public void PlaySFX2()
    {
        PlayClip(clipSFX1, sfxVolume);
    }

    public void PlayClip(AudioClip clip, float volume)
    {
        if(clip != null)
        {
            Vector3 cameraPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, cameraPos, volume);
        }
        else
        {
            Debug.Log("Clip is null, cannot play sound");
        }
    }

}
