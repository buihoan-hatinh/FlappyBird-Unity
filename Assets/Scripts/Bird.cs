using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jumpForce = 8f;

    private Rigidbody2D rb;
    private bool isDead = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isDead) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe") ||
            collision.gameObject.CompareTag("Ground"))
        {
            Die();
        }
    }

    void Die()
    {
        if (isDead) return;

        isDead = true;

       
        rb.velocity = Vector2.zero;
        rb.gravityScale = 2;
        GameManager1.Instance.ShowGameOver();
    }
}