using UnityEngine;

public class LossZone_Script : MonoBehaviour
{
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject managerScene = GameObject.FindGameObjectWithTag("ManagerScene");
            managerScene.GetComponent<ManagerMenu_Script>().GameOver();

            managerScene.GetComponent<PlayList_Script>().playerDead = transform;
            audioSource.Play();
        }
    }
}