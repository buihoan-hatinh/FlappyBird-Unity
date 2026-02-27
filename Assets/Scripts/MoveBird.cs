using UnityEngine;

public class MoveBird : MonoBehaviour
{
    public float jumpForce = 8f;   
    private Rigidbody2D rb;
    private bool isGameOver = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isGameOver) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.zero;            
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") ||
            collision.gameObject.CompareTag("Pipe"))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        isGameOver = true;
        rb.velocity = Vector2.zero;

        GameManager.Instance.ShowGameOver();
    }
   
} 