using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Script : MonoBehaviour
{
    /// <summary>
    /// BG Главного меню
    /// </summary>
    public Sprite spriteMainMenu;
    /// <summary>
    /// BG в игре
    /// </summary>
    public Sprite[] sprites;
    SpriteRenderer spriteRenderer;
    int randomSpriteBG;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SceneMenu()
    {
        spriteRenderer.sprite = spriteMainMenu;
    }

    public void SceneGame()
    {
        randomSpriteBG = Random.Range(0, sprites.Length);
        spriteRenderer.sprite = sprites[randomSpriteBG];
    }
}