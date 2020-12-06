using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift_Script : MonoBehaviour
{
    GameObject point_Gifts;
    GameObject score;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            point_Gifts = GameObject.FindGameObjectWithTag("ManagerScene");
            point_Gifts.GetComponent<AddGifts_Script>().AddGift();

            score = GameObject.FindGameObjectWithTag("ManagerScene");
            score.GetComponent<Score_Script>().NewScore();
            Destroy(gameObject);
        }
    }
}