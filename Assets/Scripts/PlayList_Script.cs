using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayList_Script : MonoBehaviour
{
    public AudioClip mainMenuClip;
    public AudioClip[] music;
    AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;

        if (GetComponent<ManagerMenu_Script>().currentScene == 0)
        {
            audioSource.clip = mainMenuClip;
            audioSource.Play();
        }
    }

    private void Update()
    {
        if (GetComponent<ManagerMenu_Script>().currentScene > 0)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.clip = GetRandomClip();
                audioSource.Play();
            }
        }
    }

    public AudioClip GetRandomClip()
    {
        return music[Random.Range(0, music.Length)];
    }
}