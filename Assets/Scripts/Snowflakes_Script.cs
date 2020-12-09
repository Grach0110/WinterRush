using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowflakes_Script : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    /// <summary>
    /// Снежинки
    /// </summary>
    public Sprite[] snowflakes;
    int randomSnowflakes;
    public float lifeTime = 10f;

    float minPosX = -20f, maxPosX = 20f, maxPosY = 16f;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        randomSnowflakes = Random.Range(0, snowflakes.Length);
        spriteRenderer.sprite = snowflakes[randomSnowflakes];
        gameObject.transform.position = new Vector3(Random.Range(minPosX,maxPosX), maxPosY, 0);

        Destroy(gameObject, lifeTime);
    }
}