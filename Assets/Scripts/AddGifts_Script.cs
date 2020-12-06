using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGifts_Script : MonoBehaviour
{
    GameObject[] points;
    int randomNumberPonts;

    public GameObject gift;

    private void Start()
    {
        points = GameObject.FindGameObjectsWithTag("PointGift");
        AddGift();
    }

    public void AddGift()
    {
        randomNumberPonts = Random.Range(0, points.Length);
        Instantiate(gift);
        gift.transform.position = points[randomNumberPonts].transform.position;
    }
}