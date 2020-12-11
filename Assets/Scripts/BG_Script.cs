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
    public Sprite[] spritesGame;
    SpriteRenderer spriteRenderer;
    /// <summary>
    /// Случайные спрайт BG в сцене с игрой
    /// </summary>
    int randomSpriteBG;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// BG меню
    /// </summary>
    public void SceneMenu()
    {
        spriteRenderer.sprite = spriteMainMenu;
    }

    /// <summary>
    /// BG в игре
    /// </summary>
    public void SceneGame()
    {
        randomSpriteBG = Random.Range(0, spritesGame.Length);
        spriteRenderer.sprite = spritesGame[randomSpriteBG];
    }
}