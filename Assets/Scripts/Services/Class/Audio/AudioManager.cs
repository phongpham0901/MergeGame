using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    [Header("SFX")] 
    [SerializeField] public AudioClip clipSFX;
    [SerializeField] [Range(0f, 1f)] public float sfxVolume = 1f;
    
    private static AudioManager instance;
    
    void Awake()
    {
        ManageInstance();
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

    public void PlaySFX()
    {
        Debug.Log("clipSFX: " + clipSFX);
        PlayClip(clipSFX, sfxVolume);
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
