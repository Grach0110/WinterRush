using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayList_Script : MonoBehaviour
{
    /// <summary>
    /// Музыка для главного меню
    /// </summary>
    public AudioClip mainMenuClip;
    /// <summary>
    /// Вся музыка - игровая сцена
    /// </summary>
    public AudioClip[] music;
    AudioSource audioSource;

    /// <summary>
    /// Игрок врезался 
    /// </summary>
    public bool playerDead;

    public void Start()
    {
        playerDead = false;

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
            if (!audioSource.isPlaying || playerDead)
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