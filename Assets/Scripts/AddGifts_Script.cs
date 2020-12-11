using UnityEngine;

public class AddGifts_Script : MonoBehaviour
{
    /// <summary>
    /// Точки появления подарков
    /// </summary>
    GameObject[] points;
    /// <summary>
    /// Случайное появление
    /// </summary>
    int randomNumberPonts;

    /// <summary>
    /// Префаб подарка
    /// </summary>
    public GameObject gift;

    /// <summary>
    /// Поиск всех точек
    /// </summary>
    public void Points()
    {
        points = GameObject.FindGameObjectsWithTag("PointGift");
    }

    /// <summary>
    /// Появление поарка
    /// </summary>
    public void AddGift()
    {
        randomNumberPonts = Random.Range(0, points.Length);
        Instantiate(gift);
        gift.transform.position = points[randomNumberPonts].transform.position;
    }
}