using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossZone_Script : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject managerScene = GameObject.FindGameObjectWithTag("ManagerScene");
            managerScene.GetComponent<ManagerMenu_Script>().GameOver();
        }
    }
}