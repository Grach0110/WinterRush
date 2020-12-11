using UnityEngine;

public class Gift_Script : MonoBehaviour
{
    /// <summary>
    /// Префаб PS
    /// </summary>
    public GameObject psGift;

    GameObject managerScene;
    GameObject score;

    /// <summary>
    /// Спрайты подарков
    /// </summary>
    public Sprite[] sprites;
    SpriteRenderer spriteRenderer;
    /// <summary>
    /// Случайный спрайт
    /// </summary>
    int randomSprite;

    BoxCollider2D boxCollider2D;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        randomSprite = Random.Range(0, sprites.Length);
        spriteRenderer.sprite = sprites[randomSprite];
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            managerScene = GameObject.FindGameObjectWithTag("ManagerScene");
            managerScene.GetComponent<AddGifts_Script>().AddGift();

            score = GameObject.FindGameObjectWithTag("ManagerScene");
            score.GetComponent<Score_Script>().NewScore();

            boxCollider2D.enabled = false;
            spriteRenderer.enabled = false;
            Instantiate(psGift,gameObject.transform);

            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<Rigidbody2D>().mass += 0.1f;

            Destroy(gameObject,10f);
        }
        else
        {
            managerScene = GameObject.FindGameObjectWithTag("ManagerScene");
            managerScene.GetComponent<AddGifts_Script>().AddGift();

            boxCollider2D.enabled = false;
            spriteRenderer.enabled = false;
            Instantiate(psGift, gameObject.transform);

            Destroy(gameObject, 10f);
        }
    }
}