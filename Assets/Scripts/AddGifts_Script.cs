using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGifts_Script : MonoBehaviour
{
    GameObject[] points;
    int randomNumberPonts;

    public GameObject[] gift;
    int randomNumberGift;

    private void Start()
    {
        points = GameObject.FindGameObjectsWithTag("PointGift");
        AddGift();
    }

    public void AddGift()
    {
        randomNumberPonts = Random.Range(0, points.Length);
        randomNumberGift = Random.Range(0, gift.Length);
        Instantiate(gift[randomNumberGift]);
        gift[randomNumberGift].transform.position = points[randomNumberPonts].transform.position;
    }
}